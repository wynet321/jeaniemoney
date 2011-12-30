using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class LocationAction
    {
        public bool createLocation(Location location)
        {
            string SQL = "insert into location values('" + location.Id + "','" + location.Name + "','" + location.Pinyin + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Location retrieveLocationById(string id)
        {
            string SQL = "select id,name,pinyin from location where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Location location = new Location();
            location.Id = id;
            location.Name = dataTable.Rows[0].ItemArray[1].ToString();
            location.Pinyin = dataTable.Rows[0].ItemArray[2].ToString();
            return location;
        }

        public List<Location> retrieveLocationList()
        {
            string SQL = "select id,name,pinyin from location";
            List<Location> locationList = retrieveLocationListBySQL(SQL);
            return locationList;
        }

        public bool deleteLocationById(string id)
        {
            string SQL = "delete from location where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<Location> retrieveLocationListByPinyin(string pinyin)
        {
            string SQL = "select id,name,pinyin from location where pinyin like '" + pinyin + "%'";
            List<Location> locationList = retrieveLocationListBySQL(SQL);
            return locationList;
        }

        public List<Location> retrieveLocationListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<Location> locationList = new List<Location>();
            Location location;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                location = new Location();
                location.Id = dataRow.ItemArray[0].ToString();
                location.Name = dataRow.ItemArray[1].ToString();
                location.Pinyin = dataRow.ItemArray[2].ToString();
                locationList.Add(location);
            }
            return locationList;
        }

        public bool updateLocationById(Location location)
        {
            string SQL = "update location set ";
            if (0 > location.Id.Length)
                return false;
            SQL += "name='" + location.Name + "',pinyin='" + location.Pinyin + "'," + " Where id='" + location.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
