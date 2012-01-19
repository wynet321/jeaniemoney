using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class ManufactoryAction
    {
        public bool createManufactory(Manufactory manufactory)
        {
            string SQL = "insert into manufactory values('" + manufactory.Id + "','" + manufactory.Name + "','" + manufactory.Abbr + "','" + manufactory.Address + "','" + manufactory.Tel + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Manufactory retrieveManufactoryById(string id)
        {
            string SQL = "select * from manufactory where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Manufactory manufactory = new Manufactory();
            manufactory.Id = id;
            manufactory.Name = dataTable.Rows[0]["name"].ToString();
            manufactory.Abbr = dataTable.Rows[0]["abbr"].ToString();
            manufactory.Address = dataTable.Rows[0]["address"].ToString();
            manufactory.Tel = dataTable.Rows[0]["tel"].ToString();
            return manufactory;
        }

        public List<Manufactory> retrieveManufactoryList()
        {
            string SQL = "select * from manufactory";
            List<Manufactory> manufactoryList = retrieveManufactoryListBySQL(SQL);
            return manufactoryList;
        }

        public bool deleteManufactoryById(string id)
        {
            string SQL = "delete from manufactory where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<Manufactory> retrieveManufactoryListByAbbr(string abbr)
        {
            string SQL = "select * from manufactory where abbr like '" + abbr + "%'";
            List<Manufactory> manufactoryList = retrieveManufactoryListBySQL(SQL);
            return manufactoryList;
        }

        public List<Manufactory> retrieveManufactoryListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<Manufactory> manufactoryList = new List<Manufactory>();
            Manufactory manufactory;
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

        public bool updateManufactoryById(Manufactory manufactory)
        {
            string SQL = "update manufactory set ";
            if (0 > manufactory.Id.Length)
                return false;
            SQL += "name='" + manufactory.Name + "',abbr='" + manufactory.Abbr + "',address='" + manufactory.Address + "',tel='" + manufactory.Tel + "' Where id='" + manufactory.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }

}
