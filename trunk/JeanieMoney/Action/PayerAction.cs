using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class PayerAction
    {
        public bool createPayer(Payer payer)
        {
            string SQL = "insert into payer values('" + payer.Id + "','" + payer.Name + "','" + payer.Abbr + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Payer retrievePayerById(string id)
        {
            string SQL = "select * from payer where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Payer payer = new Payer();
            payer.Id = id;
            payer.Name = dataTable.Rows[0]["name"].ToString();
            payer.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return payer;
        }

        public List<Payer> retrievePayerList()
        {
            string SQL = "select * from payer";
            List<Payer> payerList = retrievePayerListBySQL(SQL);
            return payerList;
        }

        public bool deletePayerById(string id)
        {
            string SQL = "delete from payer where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<Payer> retrievePayerListByAbbr(string abbr)
        {
            string SQL = "select * from payer where abbr like '" + abbr + "%'";
            List<Payer> payerList = retrievePayerListBySQL(SQL);
            return payerList;
        }

        public List<Payer> retrievePayerListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<Payer> payerList = new List<Payer>();
            Payer payer;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                payer = new Payer();
                payer.Id = dataRow["id"].ToString();
                payer.Name = dataRow["name"].ToString();
                payer.Abbr = dataRow["abbr"].ToString();
                payerList.Add(payer);
            }
            return payerList;
        }

        public bool updatePayerById(Payer payer)
        {
            string SQL = "update payer set ";
            if (0 > payer.Id.Length)
                return false;
            SQL += "name='" + payer.Name + "',abbr='" + payer.Abbr + "' Where id='" + payer.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
