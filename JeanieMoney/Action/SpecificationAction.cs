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
            string command = "insert into specification values('" + specification.Id + "','" + specification.Name + "','" + specification.Abbr + "')";
            if (1== Database.execCommand(command))
                return true;
            return false;
        }

        public Specification retrieveSpecificationById(string id)
        {
            string command = "select * from specification where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(command);
            Specification specification = new Specification();
            specification.Id = id;
            specification.Name = dataTable.Rows[0]["name"].ToString();
            specification.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return specification;
        }

        public List<Specification> retrieveSpecificationList()
        {
            string command = "select id,name,abbr from specification";
            List<Specification> specificationList = retrieveSpecificationListBySQL(command);
            return specificationList;
        }

        public bool deleteSpecificationById(string id)
        {
            string command = "delete from specification where id='" + id + "'";
            if (0 < Database.execCommand(command))
                return true;
            return false;
        }
        public List<Specification> retrieveSpecificationListByAbbr(string abbr)
        {
            string command = "select * from specification where abbr like '" + abbr + "%'";
            List<Specification> specificationList = retrieveSpecificationListBySQL(command);
            return specificationList;
        }

        public List<Specification> retrieveSpecificationListBySQL(string command)
        {
            DataTable dataTable = Database.getDataTable(command);
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
            string command = "update specification set ";
            if (0 > specification.Id.Length)
                return false;
            command += "name='" + specification.Name + "',abbr='" + specification.Abbr + "' Where id='" + specification.Id.Trim() + "'";

            if (0 < Database.execCommand(command))
                return true;
            return false;
        }
    }

}
