﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;

namespace JeanieMoney.Utility
{
    class Database
    {
        private static DbProviderFactory dbProviderFactory;
        private static DbConnection connection;

        private static DbConnection getConnection()
        {
            if (null == connection)
            {
                //Todo: need add to config file.
                dbProviderFactory = DbProviderFactories.GetFactory(ProviderName.getPIN("SQLSERVER"));
                connection = dbProviderFactory.CreateConnection();
                connection.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=JeanieMoney;Integrated Security=True";
                connection.Open();
            }
            return connection;
        }

        public static int execTranx(string[] commands)
        {
            DbConnection localconnection = getConnection();
            DbCommand localcommand = connection.CreateCommand();
            DbTransaction tranx = connection.BeginTransaction();
            int affectedRows = 0;
            try
            {
                foreach (string command in commands)
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
        public static DataTable execQuery(string command)
        {
            DbConnection localConnection = getConnection();
            DbCommand localCommand = connection.CreateCommand();
            localCommand.CommandText = command;
            DbDataAdapter dbDataAdapter = dbProviderFactory.CreateDataAdapter();
            dbDataAdapter.SelectCommand = localCommand;
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static object execQuery(string command)
        {
            DbConnection localConnection = getConnection();
            DbCommand localCommand = connection.CreateCommand();
            localCommand.CommandText = command;
            return localCommand.ExecuteScalar();
        }

    }
}
