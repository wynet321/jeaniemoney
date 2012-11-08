using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using ClassLibrary.lib;
using System.Data;
using ClassLibrary.lib.Handler;
using System.Data.Common;

namespace JeanieMoney.Actions
{
    class PayerAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Payer payer)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",payer.Id,payer.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", payer.Name, payer.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", payer.Abbr, payer.Abbr.GetType().Name),
                    dbHandler.generateDbParameter("@password", payer.Password, payer.Password.GetType().Name)
                    };
            return dbParameterArray;
        }
        public bool createPayer(Payer payer)
        {
            string command = "insert into payer values(@id,@name,@abbr,@password)";
            DbParameter[] dbParameterArray = generateDbParameterArray(payer);
            if (1== HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public Payer retrieve(Payer payer)
        {
            string command = "select * from payer where id=@id";
            if (string.IsNullOrWhiteSpace(payer.Id))
                return payer;
            DbParameter[] dbParameterArray = generateDbParameterArray(payer);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            payer = new Payer();
            payer.Id = 
            payer.Name = dataTable.Rows[0]["name"].ToString();
            payer.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return payer;
        }

        //public List<Payer> retrievePayerList()
        //{
        //    string command = "select * from payer";
        //    List<Payer> payerList = retrievePayerListBySQL(command);
        //    return payerList;
        //}

        public bool delete(Payer payer)
        {
            string command = "delete from payer where id=@id";
            if (string.IsNullOrWhiteSpace(payer.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(payer);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<Payer> retrievePayerListByAbbr(string abbr)
        //{
        //    string command = "select * from payer where abbr like '" + abbr + "%'";
        //    List<Payer> payerList = retrievePayerListBySQL(command);
        //    return payerList;
        //}

        public List<Payer> retrieveList(Payer payer)
        {
            string command = "select * from payer";
            if (string.IsNullOrWhiteSpace(payer.Abbr))
                command += " where abbr like @abbr%";
            DbParameter[] dbParameterArray = generateDbParameterArray(payer);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Payer> payerList = new List<Payer>();
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
            string command = "update payer set name=@name,abbr=@abbr,password=@password Where id=@id";
            if (string.IsNullOrWhiteSpace(payer.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(payer);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }
}
