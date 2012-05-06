﻿using System;
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
        private static readonly List<KeyValuePair<String, String>> dbType = new List<KeyValuePair<String, String>>();
        private static DbProviderFactory dbProviderFactory;
        private static DbConnection connection;

        public static List<KeyValuePair<String, String>> getDbType()
        {
            dbType.Add(new KeyValuePair<String, String>("SQLSERVER", "System.Data.SqlClient"));
            dbType.Add(new KeyValuePair<string, string>("ODBC", "System.Data.Odbc"));
            //dbType.Add(new KeyValuePair<string,string>("OLEDB","System.Data.OleDb"));
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

                }
            }
            return connection;
        }

        public static void setConnection(String dbType, String connectionString)
        {
            try
            {
                dbProviderFactory = DbProviderFactories.GetFactory(dbType);
                connection = dbProviderFactory.CreateConnection();
                connection.ConnectionString = connectionString;
                //connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }

        }

        public static Boolean canConnect()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;

        }

        public static int execTranx(List<string> commandList)
        {
            DbCommand dbCommand;
            DbTransaction dbTranx;
            int affectedRows = 0;
            dbCommand = connection.CreateCommand();
            dbTranx = connection.BeginTransaction();
            dbCommand.Transaction = dbTranx;
            try
            {

                connection.Open();
                foreach (string command in commandList)
                {
                    dbCommand.CommandText = command;
                    affectedRows += dbCommand.ExecuteNonQuery();
                }
                dbTranx.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                try
                {
                    dbTranx.Rollback();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                connection.Close();
            }
            return affectedRows;
        }

        public static int execCommand(string command)
        {
            DbCommand dbCommand = connection.CreateCommand();
            int affectedRows = 0;
            dbCommand.CommandText = command;
            try
            {
                affectedRows = dbCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return affectedRows;
        }
        public static DataTable getDataTable(string command)
        {
            DbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = command;
            DbDataAdapter dbDataAdapter = dbProviderFactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = dbCommand;
            DataTable dataTable = new DataTable();
            try
            {
                dbDataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static object getValue(string command)
        {
            
            DbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = command;
            object result = new object();
            try
            {
                connection.Open();
                result = dbCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

    }
}
