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
    class LocationAction : IAction<Location>
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Location location)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",location.Id,location.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", location.Name, location.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", location.Abbr, location.Abbr.GetType().Name),
            };
            return dbParameterArray;
        }

        public bool create(Location location)
        {
            string command = "insert into location values(@id,@name,@abbr)";
            DbParameter[] dbParameterArray = generateDbParameterArray(location);
            if (1==HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public Location retrieve(Location location)
        {
            string command = "select * from location where id=@id";
            if (string.IsNullOrWhiteSpace(location.Id))
                return location;
            DbParameter[] dbParameterArray = generateDbParameterArray(location);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            location = new Location();
            location.Id = dataTable.Rows[0]["id"].ToString();
            location.Name = dataTable.Rows[0]["name"].ToString();
            location.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return location;
        }

        //public List<Location> retrieveList()
        //{
        //    string command = "select * from location";
        //    List<Location> locationList = retrieveLocationListBySQL(command);
        //    return locationList;
        //}

        public bool delete(Location location)
        {
            string command = "delete from location where id=@id";
            if (string.IsNullOrWhiteSpace(location.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(location);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<Location> retrieveLocationListByAbbr(string abbr)
        //{
        //    string command = "select * from location where abbr like '" + abbr + "%'";
        //    List<Location> locationList = retrieveLocationListBySQL(command);
        //    return locationList;
        //}

        public List<Location> retrieveList(Location location)
        {
            string command = "select * from location";
            if (string.IsNullOrWhiteSpace(location.Abbr))
                command += " where abbr=@abbr";
            DbParameter[] dbParameterArray = generateDbParameterArray(location);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Location> locationList = new List<Location>();
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

        public bool update(Location location)
        {
            string command = "update location set name=@name,abbr=@abbr Where id=@id";
            if (0 > location.Id.Length)
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(location);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }
}
