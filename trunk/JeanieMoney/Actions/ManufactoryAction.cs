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
    class ManufactoryAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Manufactory manufactory)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",manufactory.Id,manufactory.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", manufactory.Name, manufactory.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", manufactory.Abbr, manufactory.Abbr.GetType().Name),
                    dbHandler.generateDbParameter("@address", manufactory.Address, manufactory.Address.GetType().Name),
                    dbHandler.generateDbParameter("@tel", manufactory.Tel, manufactory.Tel.GetType().Name)
            };
            return dbParameterArray;
        }
        public bool create(Manufactory manufactory)
        {
            string command = "insert into manufactory values(@id,@name,@abbr,@address,@tel)";
            DbParameter[] dbParameterArray = generateDbParameterArray(manufactory);
            if (1== HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public Manufactory retrieve(Manufactory manufactory)
        {
            string command = "select * from manufactory where id=@id";
            if (string.IsNullOrWhiteSpace(manufactory.Id))
                return manufactory;
            DbParameter[] dbParameterArray = generateDbParameterArray(manufactory);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            manufactory = new Manufactory();
            manufactory.Id = dataTable.Rows[0]["id"].ToString();
            manufactory.Name = dataTable.Rows[0]["name"].ToString();
            manufactory.Abbr = dataTable.Rows[0]["abbr"].ToString();
            manufactory.Address = dataTable.Rows[0]["address"].ToString();
            manufactory.Tel = dataTable.Rows[0]["tel"].ToString();
            return manufactory;
        }

        //public List<Manufactory> retrieveManufactoryList()
        //{
        //    string command = "select * from manufactory";
        //    List<Manufactory> manufactoryList = retrieveManufactoryListBySQL(command);
        //    return manufactoryList;
        //}

        public bool delete(Manufactory manufactory)
        {
            string command = "delete from manufactory where id=@id";
            if (string.IsNullOrWhiteSpace(manufactory.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(manufactory);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<Manufactory> retrieveManufactoryListByAbbr(string abbr)
        //{
        //    string command = "select * from manufactory where abbr like '" + abbr + "%'";
        //    List<Manufactory> manufactoryList = retrieveManufactoryListBySQL(command);
        //    return manufactoryList;
        //}

        public List<Manufactory> retrieveList(Manufactory manufactory)
        {
            string command = "select * from manufactory";
            if (string.IsNullOrWhiteSpace(manufactory.Abbr))
                command += " where abbr like @abbr%";
            DbParameter[] dbParameterArray = generateDbParameterArray(manufactory);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Manufactory> manufactoryList = new List<Manufactory>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                manufactory = new Manufactory();
                manufactory.Id = dataRow["id"].ToString();
                manufactory.Name = dataRow["name"].ToString();
                manufactory.Abbr = dataRow["abbr"].ToString();
                manufactory.Address = dataRow["address"].ToString();
                manufactory.Tel = dataRow["tel"].ToString();
                manufactoryList.Add(manufactory);
            }
            return manufactoryList;
        }

        public bool update(Manufactory manufactory)
        {
            string command = "update manufactory set name=@name,abbr=@abbr,address=@address,tel=@tel Where id=@id";
            if (string.IsNullOrWhiteSpace(manufactory.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(manufactory);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }

}
