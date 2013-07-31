using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using ClassLibrary.lib.Handler;

namespace ClassLibrary.lib.DBImpl
{
    public class CSqlServerImpl : IDbHandler
    {
        private SqlConnection sqlConnection;

        public CSqlServerImpl(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool isValid()
        {
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                //todo: deal with exception
                return false;
            }
            return true;
        }

        public DbConnection getConnection()
        {
            return sqlConnection;
        }

        public DbCommand generateDbCommand(string command, DbParameter[] parameters)
        {
            SqlCommand sqlCommand = (SqlCommand)getConnection().CreateCommand();
            sqlCommand.CommandText = command;
            sqlCommand.CommandType = CommandType.Text;
            if (parameters != null && parameters.Length > 0)
            {
                sqlCommand.Parameters.AddRange(parameters);
            }
            return sqlCommand;
        }

        public int execCommand(string command, DbParameter[] parameters)
        {

            SqlCommand dbCommand = (SqlCommand)generateDbCommand(command, parameters);

            int affectedRows = 0;
            getConnection().Open();
            try
            {
                affectedRows = dbCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string parameter = "";
                foreach (DbParameter param in parameters)
                {
                    parameter += param.Value.ToString();
                }
                HandlerFactory.getLogHandler().error("Fail to run command: " + command + ", parameter: {1}" + parameter + "\n" + e.StackTrace);
                throw e;
            }
            finally
            {
                getConnection().Close();
            }

            return affectedRows;
        }

        public DbParameter generateDbParameter(string parameterName, object value, string objectClassName = "string", System.Data.ParameterDirection parameterDirection = ParameterDirection.Input)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = parameterName;
            sqlParameter.Value = value;
            sqlParameter.SqlDbType = getDbParameterType(objectClassName);
            sqlParameter.Direction = parameterDirection;
            return sqlParameter;
        }

        private SqlDbType getDbParameterType(string objectClassName)
        {
            switch (objectClassName)
            {
                case "Guid": return SqlDbType.UniqueIdentifier;
                case "String": return SqlDbType.VarChar;
                case "Byte[]": return SqlDbType.Image;
                case "Decimal": return SqlDbType.Decimal;
            }
            return SqlDbType.VarChar;
        }

        public System.Data.DataTable getDataTable(string command, DbParameter[] parameters)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = (SqlCommand)generateDbCommand(command, parameters);
            DataTable dataTable = new DataTable();

            try
            {
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                string parameter = "";
                foreach (DbParameter param in parameters)
                {
                    parameter += param.Value.ToString();
                }
                HandlerFactory.getLogHandler().error("Fail to run command: " + command + ", parameter: {1}" + parameter + "\n" + e.StackTrace);
                throw e;
            }

            return dataTable;
        }

        public object getValue(string command, DbParameter[] parameters)
        {
            SqlCommand sqlCommand = (SqlCommand)generateDbCommand(command, parameters);
            object result = new object();
            try
            {
                result = sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                string parameter = "";
                foreach (DbParameter param in parameters)
                {
                    parameter += param.Value.ToString();
                }
                HandlerFactory.getLogHandler().error("Fail to run command: " + command + ", parameter: {1}" + parameter + "\n" + e.StackTrace);
                throw e;
            }

            return result;
        }

        public int execTranx(IList<SqlCommand> commandList, IList<DbParameter[]> parametersList)
        {
            SqlTransaction sqlTranx;
            SqlCommand currentCommand = new SqlCommand(); ;
            int affectedRows = 0;

            //sqlCommand = (SqlCommand)getConnection().CreateCommand();
            sqlTranx = (SqlTransaction)getConnection().BeginTransaction();
            //sqlCommand.Transaction = sqlTranx;

            try
            {
                for (int i = 0; i < commandList.Count; i++)
                {
                    currentCommand = commandList[i];
                    currentCommand.Transaction = sqlTranx;
                    currentCommand.Parameters.AddRange(parametersList[i]);
                    affectedRows += currentCommand.ExecuteNonQuery();
                }
                sqlTranx.Commit();
            }
            catch (Exception e)
            {
                //log the exception command
                string parameters = "{";
                foreach (DbParameter dbParameter in currentCommand.Parameters)
                    parameters += dbParameter.Value + ",";
                if (parameters.EndsWith(","))
                    parameters = parameters.Remove(parameters.Length - 2);
                parameters += "}\n";
                HandlerFactory.getLogHandler().error("Fail to run command: " + currentCommand.CommandText + ", parameter: {1}" + currentCommand.Parameters + "\n" + e.StackTrace);

                //log the whole transaction commands
                string commands = "";
                for (int i = 0; i < commandList.Count; i++)
                {
                    commands += commandList[i] + "{";
                    foreach (DbParameter dbParameter in parametersList[i])
                    {
                        commands += dbParameter.Value + ",";
                    }
                    if (commands.EndsWith(","))
                        commands = commands.Remove(commands.Length - 2);
                    commands += "}\n";
                }
                HandlerFactory.getLogHandler().debug("Transaction commands and parameters: " + commands);
                sqlTranx.Rollback();
                throw e;
            }
            return affectedRows;
        }
    }
}
