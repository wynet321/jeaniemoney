using System.Collections.Generic;
using JeanieMoney.Entities;
using JeanieMoney.Utility;
using System.Data;
using System;

namespace JeanieMoney.Actions
{
    class PayerAction:IAction
    {
        public Boolean createPayer(Payer payer)
        {
            string command = "insert into payer values('" + payer.Id + "','" + payer.Name + "','" + payer.Abbr + "','"+payer.Password+"')";
            if (1== DbHandler.execCommand(command))
                return true;
            return false;
        }

        public Payer retrievePayerById(string id)
        {
            string command = "select * from payer where id='" + id + "'";
            DataTable dataTable = DbHandler.getDataTable(command);
            Payer payer = new Payer();
            payer.Id = id;
            payer.Name = dataTable.Rows[0]["name"].ToString();
            payer.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return payer;
        }

        public List<Payer> retrievePayerList()
        {
            string command = "select * from payer";
            List<Payer> payerList = retrievePayerListBySQL(command);
            return payerList;
        }

        public bool deletePayerById(string id)
        {
            string command = "delete from payer where id='" + id + "'";
            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }
        public List<Payer> retrievePayerListByAbbr(string abbr)
        {
            string command = "select * from payer where abbr like '" + abbr + "%'";
            List<Payer> payerList = retrievePayerListBySQL(command);
            return payerList;
        }

        public List<Payer> retrievePayerListBySQL(string command)
        {
            DataTable dataTable = DbHandler.getDataTable(command);
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
            string command = "update payer set ";
            if (0 > payer.Id.Length)
                return false;
            command += "name='" + payer.Name + "',abbr='" + payer.Abbr + "',password='"+payer.Password+"' Where id='" + payer.Id.Trim() + "'";

            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }

        bool IAction.create(Entity entity)
        {
            throw new NotImplementedException();
        }

        Entity IAction.retrieve(Entity entity)
        {
            throw new NotImplementedException();
        }

       

        bool IAction.update(Entity entity)
        {
            throw new NotImplementedException();
        }

        bool IAction.delete(Entity entity)
        {
            throw new NotImplementedException();
        }


       List<T> IAction.retrieveList<T>(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
