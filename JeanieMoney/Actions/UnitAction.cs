using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using System.Data;
using ClassLibrary.lib;
using ClassLibrary.lib.Handler;
using System.Data.Common;

namespace JeanieMoney.Actions
{
    class UnitAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Unit unit)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",unit.Id,unit.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", unit.Name, unit.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", unit.Abbr, unit.Abbr.GetType().Name)
                    };
            return dbParameterArray;
        }
        public bool create(Unit unit)
        {
            string command = "insert into unit values(@id,@name,@abbr)";
            DbParameter[] dbParameterArray = generateDbParameterArray(unit);
            if (1== HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public Unit retrieve(Unit unit)
        {
            string command = "select * from unit where id=@id";
            if (string.IsNullOrWhiteSpace(unit.Id))
                return unit;
            DbParameter[] dbParameterArray = generateDbParameterArray(unit);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            unit = new Unit();
            unit.Id = dataTable.Rows[0]["id"].ToString();
            unit.Name = dataTable.Rows[0]["name"].ToString();
            unit.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return unit;
        }

        //public List<Unit> retrieveUnitList()
        //{
        //    string command = "select id,name,abbr from unit";
        //    List<Unit> unitList = retrieveUnitListBySQL(command);
        //    return unitList;
        //}

        public bool delete(Unit unit)
        {
            string command = "delete from unit where id=@id";
            if (string.IsNullOrWhiteSpace(unit.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(unit);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<Unit> retrieveUnitListByAbbr(string abbr)
        //{
        //    string command = "select * from unit where abbr like '" + abbr + "%'";
        //    List<Unit> unitList = retrieveUnitListBySQL(command);
        //    return unitList;
        //}

        public List<Unit> retrieveList(Unit unit)
        {
            string command = "select * from unit";
            if (string.IsNullOrWhiteSpace(unit.Id))
                command += " where abbr like @abbr%";
            DbParameter[] dbParameterArray = generateDbParameterArray(unit);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Unit> unitList = new List<Unit>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                unit = new Unit();
                unit.Id = dataRow["id"].ToString();
                unit.Name = dataRow["name"].ToString();
                unit.Abbr = dataRow["abbr"].ToString();
                unitList.Add(unit);
            }
            return unitList;
        }

        public bool updateUnitById(Unit unit)
        {
            string command = "update unit set name=@name,abbr=@abbr Where id=@id";
            if (string.IsNullOrWhiteSpace(unit.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(unit);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }

}
