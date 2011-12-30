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
            string SQL = "insert into payer values('" + payer.Id + "','" + payer.Name + "','" + payer.Pinyin + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Payer retrievePayerById(string id)
        {
            string SQL = "select id,name,pinyin from payer where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Payer payer = new Payer();
            payer.Id = id;
            payer.Name = dataTable.Rows[0].ItemArray[1].ToString();
            payer.Pinyin = dataTable.Rows[0].ItemArray[2].ToString();
            return payer;
        }

        public List<Payer> retrievePayerList()
        {
            string SQL = "select id,name,pinyin from payer";
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
        public List<Payer> retrievePayerListByPinyin(string pinyin)
        {
            string SQL = "select id,name,pinyin from payer where pinyin like '" + pinyin + "%'";
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
                payer.Id = dataRow.ItemArray[0].ToString();
                payer.Name = dataRow.ItemArray[1].ToString();
                payer.Pinyin = dataRow.ItemArray[2].ToString();
                payerList.Add(payer);
            }
            return payerList;
        }

        public bool updatePayerById(Payer payer)
        {
            string SQL = "update payer set ";
            if (0 > payer.Id.Length)
                return false;
            SQL += "name='" + payer.Name + "',pinyin='" + payer.Pinyin + "'," + " Where id='" + payer.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
