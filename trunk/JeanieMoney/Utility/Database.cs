using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace JeanieMoney.Utility
{
    class Database
    {
        OleDbConnection connection;
        private OleDbConnection getConnection()
        {
            if (null == connection)
                connection = new OleDbConnection("Data Source=localhost\\sqlexpress;Initial Catalog=JeanieMoney;Integrated Security=True");
            return connection;
        }

        public bool execTranx(string command)
        {
            OleDbConnection localconnection = getConnection();
            OleDbCommand localcommand = new OleDbCommand();
            OleDbTransaction tranx = connection.BeginTransaction();
            try
            {
                localconnection.Open();
                tranx.Begin();
                localcommand.CommandText = command;
                localcommand.ExecuteNonQuery();
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

            
            return true;
        }

        public DataSet execQuery(string command)
        {
            DataSet ds = new DataSet();

            return ds;
        }
    }
}
