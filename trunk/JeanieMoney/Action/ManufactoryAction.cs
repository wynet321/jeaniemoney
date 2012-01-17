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
            string SQL = "insert into manufactory values('" + manufactory.Id + "','" + manufactory.Name + "','" + manufactory.Pinyin + "','" + manufactory.Address + "','" + manufactory.Tel + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Manufactory retrieveManufactoryById(string id)
        {
            string SQL = "select id,name,pinyin,address,tel from manufactory where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Manufactory manufactory = new Manufactory();
            manufactory.Id = id;
            manufactory.Name = dataTable.Rows[0].ItemArray[1].ToString();
            manufactory.Pinyin = dataTable.Rows[0].ItemArray[2].ToString();
            manufactory.Address=dataTable.Rows[0].ItemArray[3].ToString();
            manufactory.Tel=dataTable.Rows[0].ItemArray[4].ToString();
            return manufactory;
        }

        public List<Manufactory> retrieveManufactoryList()
        {
            string SQL = "select id,name,pinyin,address,tel from manufactory";
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
        public List<Manufactory> retrieveManufactoryListByPinyin(string pinyin)
        {
            string SQL = "select id,name,pinyin,address,tel from manufactory where pinyin like '" + pinyin + "%'";
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
                manufactory.Id = dataRow.ItemArray[0].ToString();
                manufactory.Name = dataRow.ItemArray[1].ToString();
                manufactory.Pinyin = dataRow.ItemArray[2].ToString();
                manufactory.Address=dataRow.ItemArray[3].ToString();
                manufactory.Tel=dataRow.ItemArray[4].ToString();
                manufactoryList.Add(manufactory);
            }
            return manufactoryList;
        }

        public bool updateManufactoryById(Manufactory manufactory)
        {
            string SQL = "update manufactory set ";
            if (0 > manufactory.Id.Length)
                return false;
            SQL += "name='" + manufactory.Name + "',pinyin='" + manufactory.Pinyin + "',address='"+manufactory.Address +"',tel='"+manufactory.Tel+"' Where id='" + manufactory.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
    }
}
