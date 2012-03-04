using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class UnitAction
    {
        public bool createUnit(Unit unit)
        {
            string command = "insert into unit values('" + unit.Id + "','" + unit.Name + "','" + unit.Abbr + "')";
            if (1== JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }

        public Unit retrieveUnitById(string id)
        {
            string command = "select * from unit where id='" + id + "'";
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            Unit unit = new Unit();
            unit.Id = id;
            unit.Name = dataTable.Rows[0]["name"].ToString();
            unit.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return unit;
        }

        public List<Unit> retrieveUnitList()
        {
            string command = "select id,name,abbr from unit";
            List<Unit> unitList = retrieveUnitListBySQL(command);
            return unitList;
        }

        public bool deleteUnitById(string id)
        {
            string command = "delete from unit where id='" + id + "'";
            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
        public List<Unit> retrieveUnitListByAbbr(string abbr)
        {
            string command = "select * from unit where abbr like '" + abbr + "%'";
            List<Unit> unitList = retrieveUnitListBySQL(command);
            return unitList;
        }

        public List<Unit> retrieveUnitListBySQL(string command)
        {
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            List<Unit> unitList = new List<Unit>();
            Unit unit;
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
            string command = "update unit set ";
            if (0 > unit.Id.Length)
                return false;
            command += "name='" + unit.Name + "',abbr='" + unit.Abbr + "' Where id='" + unit.Id.Trim() + "'";

            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
    }

}
