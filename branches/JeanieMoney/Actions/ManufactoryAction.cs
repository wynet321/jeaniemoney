using System.Collections.Generic;
using JeanieMoney.Utility;
using System.Data;
using JeanieMoney.Entities;

namespace JeanieMoney.Actions
{
    class ManufactoryAction
    {
        public bool createManufactory(Manufactory manufactory)
        {
            string command = "insert into manufactory values('" + manufactory.Id + "','" + manufactory.Name + "','" + manufactory.Abbr + "','" + manufactory.Address + "','" + manufactory.Tel + "')";
            if (1== DbHandler.execCommand(command))
                return true;
            return false;
        }

        public Manufactory retrieveManufactoryById(string id)
        {
            string command = "select * from manufactory where id='" + id + "'";
            DataTable dataTable = DbHandler.getDataTable(command);
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
            string command = "select * from manufactory";
            List<Manufactory> manufactoryList = retrieveManufactoryListBySQL(command);
            return manufactoryList;
        }

        public bool deleteManufactoryById(string id)
        {
            string command = "delete from manufactory where id='" + id + "'";
            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }
        public List<Manufactory> retrieveManufactoryListByAbbr(string abbr)
        {
            string command = "select * from manufactory where abbr like '" + abbr + "%'";
            List<Manufactory> manufactoryList = retrieveManufactoryListBySQL(command);
            return manufactoryList;
        }

        public List<Manufactory> retrieveManufactoryListBySQL(string command)
        {
            DataTable dataTable = DbHandler.getDataTable(command);
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
            string command = "update manufactory set ";
            if (0 > manufactory.Id.Length)
                return false;
            command += "name='" + manufactory.Name + "',abbr='" + manufactory.Abbr + "',address='" + manufactory.Address + "',tel='" + manufactory.Tel + "' Where id='" + manufactory.Id.Trim() + "'";

            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }
    }

}
