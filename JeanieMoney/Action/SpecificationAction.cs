using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class SpecificationAction
    {
        public bool createSpecification(Specification specification)
        {
            string SQL = "insert into specification values('" + specification.Id + "','" + specification.Name + "','" + specification.Abbr + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Specification retrieveSpecificationById(string id)
        {
            string SQL = "select * from specification where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Specification specification = new Specification();
            specification.Id = id;
            specification.Name = dataTable.Rows[0]["name"].ToString();
            specification.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return specification;
        }

        public List<Specification> retrieveSpecificationList()
        {
            string SQL = "select id,name,abbr from specification";
            List<Specification> specificationList = retrieveSpecificationListBySQL(SQL);
            return specificationList;
        }

        public bool deleteSpecificationById(string id)
        {
            string SQL = "delete from specification where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<Specification> retrieveSpecificationListByAbbr(string abbr)
        {
            string SQL = "select * from specification where abbr like '" + abbr + "%'";
            List<Specification> specificationList = retrieveSpecificationListBySQL(SQL);
            return specificationList;
        }

        public List<Specification> retrieveSpecificationListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<Specification> specificationList = new List<Specification>();
            Specification specification;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                specification = new Specification();
                specification.Id = dataRow["id"].ToString();
                specification.Name = dataRow["name"].ToString();
                specification.Abbr = dataRow["abbr"].ToString();
                specificationList.Add(specification);
            }
            return specificationList;
        }

        public bool updateSpecificationById(Specification specification)
        {
            string SQL = "update specification set ";
            if (0 > specification.Id.Length)
                return false;
            SQL += "name='" + specification.Name + "',abbr='" + specification.Abbr + "' Where id='" + specification.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }

}
