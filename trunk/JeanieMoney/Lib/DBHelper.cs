using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Collections.Generic;

namespace JeanieMoney.Utility
{
    class DBHelper
    {
        private static DbProviderFactory dbProviderFactory;
        private static DbConnection connection;
        private static string SQLSERVER = "System.Data.SqlClient";
        private static string DB2 = "IBM.Data.DB2.iSeries";
        private static string ORACLE = "Oracle.DataAccess.Client";
        private static string OLEDB = "System.Data.OleDb";
        private static string ODBC = "System.Data.ODBC";
        private static string MYSQL = "MySql.Data.MySqlClient";
        private static string SQLITE = "System.Data.SQLite";
        private static string FIREBIRD = "FirebirdSql.Data.Firebird";
        private static string POSTGRESQL = "Npgsql";
        private static string INFORMIX = "IBM.Data.Informix";
        private static string SQLSERVERCE = "System.Data.SqlServerCe";
        private static DbConnection getConnection()
        {
            if (null == connection)
            {
                //Todo: need add to config file.
                dbProviderFactory = DbProviderFactories.GetFactory(SQLSERVER);
                connection = dbProviderFactory.CreateConnection();
                connection.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=JeanieMoney;Integrated Security=True";
            }
            connection.Open();
            return connection;
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
