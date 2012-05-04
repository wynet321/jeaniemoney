using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;

namespace JeanieMoney.Utility
{
    class DBHandler
    {
        private static readonly List<KeyValuePair<String,String>> dbType=new List<KeyValuePair<String,String>>();
        private static DbProviderFactory dbProviderFactory;
        private static DbConnection connection;

         public static List<KeyValuePair<String, String>> getDbType()
        {
            dbType.Add(new KeyValuePair<String,String>("SQLSERVER", "System.Data.SqlClient"));
            dbType.Add(new KeyValuePair<string,string>("ODBC","System.Data.Odbc"));
            dbType.Add(new KeyValuePair<string,string>("OLEDB","System.Data.OleDb"));
            dbType.Add(new KeyValuePair<string,string>("ORACLE","System.Data.OracleClient"));
            dbType.Add(new KeyValuePair<string,string>("SQLCE","System.Data.SqlServerCe"));
            return dbType;
        }

        private static DbConnection getConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Application.Exit();
                }
            }
            return connection;
        }

        public static void setConnection(String dbType, String connectionString)
        {
                //Todo: need add to config file.
                dbProviderFactory = DbProviderFactories.GetFactory(dbType);
                connection = dbProviderFactory.CreateConnection();
                connection.ConnectionString = connectionString;
        }

        public static int execTranx(List<string> commandList)
        {
            DbConnection localconnection = getConnection();
            DbCommand localcommand = connection.CreateCommand();
            DbTransaction tranx = connection.BeginTransaction();
            localcommand.Transaction = tranx;
            int affectedRows = 0;
            try
            {
                foreach (string command in commandList)
                {
                    localcommand.CommandText = command;
                    affectedRows += localcommand.ExecuteNonQuery();
                }
                tranx.Commit();
            }
            catch (Exception e)
            {
                try
                {
                    tranx.Rollback();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(e.Message);
            }
            finally
            {
                localconnection.Close();
            }
            return affectedRows;
        }

        public static int execCommand(string command)
        {
            DbConnection localconnection = getConnection();
            DbCommand localcommand = connection.CreateCommand();
            int affectedRows = 0;
            localcommand.CommandText = command;
            affectedRows = localcommand.ExecuteNonQuery();
            localconnection.Close();
            return affectedRows;
        }
        public static DataTable getDataTable(string command)
        {
            DbConnection localConnection = getConnection();
            DbCommand localCommand = connection.CreateCommand();
            localCommand.CommandText = command;
            DbDataAdapter dbDataAdapter = dbProviderFactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = localCommand;
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            localConnection.Close();
            return dataTable;
        }

        public static object getValue(string command)
        {
            DbConnection localConnection = getConnection();
            DbCommand localCommand = connection.CreateCommand();
            localCommand.CommandText = command;
            localConnection.Close();
            return localCommand.ExecuteScalar();
        }

    }
}
