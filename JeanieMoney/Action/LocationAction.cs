﻿using System;
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
            string command = "insert into location values('" + location.Id + "','" + location.Name + "','" + location.Abbr + "')";
            if (1==JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }

        public Location retrieveLocationById(string id)
        {
            string command = "select * from location where id='" + id + "'";
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            Location location = new Location();
            location.Id = id;
            location.Name = dataTable.Rows[0]["name"].ToString();
            location.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return location;
        }

        public List<Location> retrieveLocationList()
        {
            string command = "select * from location";
            List<Location> locationList = retrieveLocationListBySQL(command);
            return locationList;
        }

        public bool deleteLocationById(string id)
        {
            string command = "delete from location where id='" + id + "'";
            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
        public List<Location> retrieveLocationListByAbbr(string abbr)
        {
            string command = "select * from location where abbr like '" + abbr + "%'";
            List<Location> locationList = retrieveLocationListBySQL(command);
            return locationList;
        }

        public List<Location> retrieveLocationListBySQL(string command)
        {
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            List<Location> locationList = new List<Location>();
            Location location;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                location = new Location();
                location.Id = dataRow["id"].ToString();
                location.Name = dataRow["name"].ToString();
                location.Abbr = dataRow["abbr"].ToString();
                locationList.Add(location);
            }
            return locationList;
        }

        public bool updateLocationById(Location location)
        {
            string command = "update location set ";
            if (0 > location.Id.Length)
                return false;
            command += "name='" + location.Name + "',abbr='" + location.Abbr + "' Where id='" + location.Id.Trim() + "'";

            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
    }
}
