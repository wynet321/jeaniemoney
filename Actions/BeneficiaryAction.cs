using System;
using System.Collections.Generic;
using JeanieMoney.Utility;
using System.Data;
using JeanieMoney.Entities;

namespace JeanieMoney.Actions
{
    class BeneficiaryAction :IAction
    {
        private void antiSqlInjection(Beneficiary beneficiary)
        {
            if (beneficiary == null)
                return;
            if (!string.IsNullOrWhiteSpace(beneficiary.Id))
                beneficiary.Id = beneficiary.Id.Replace("'", "''");
            if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                beneficiary.Name = beneficiary.Name.Replace("'", "''");
            if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                beneficiary.Abbr = beneficiary.Abbr.Replace("'", "''");
        }
        public Boolean create(Entity entity)
        {
            Beneficiary beneficiary = (Beneficiary)entity;
            antiSqlInjection(beneficiary);
            string command = "insert into beneficiary values('" + beneficiary.Id + "','" + beneficiary.Name + "','" + beneficiary.Abbr + "')";
            if (1 == DbHandler.execCommand(command))
                return true;
            return false;
        }

        public Entity retrieve(Entity entity)
        {
            Beneficiary beneficiary = (Beneficiary)entity;
            String command = "select * from beneficiary";
            if (beneficiary != null)
            {
                antiSqlInjection(beneficiary);
                command += " where 1=1 and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Id))
                    command += "id='" + beneficiary.Id + "' and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                    command += "name='" + beneficiary.Name + "' and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                    command += "abbr='" + beneficiary.Abbr + "' and ";
                command=command.Remove(command.Length - 5);
            }
            DataTable dataTable = DbHandler.getDataTable(command);
            Beneficiary beneficiaryResult = new Beneficiary();
            beneficiaryResult.Id = dataTable.Rows[0]["id"].ToString();
            beneficiaryResult.Name = dataTable.Rows[0]["name"].ToString();
            beneficiaryResult.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return beneficiaryResult;
        }

        public List<T> retrieveList<T>(Entity entity) where T:Entity,new()
        {
            Beneficiary beneficiary = (Beneficiary)entity;
            
            String command = "select * from beneficiary";
            if (beneficiary != null)
            {
                antiSqlInjection(beneficiary);
                command += " where 1=1 and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Id))
                    command += "id like '" + beneficiary.Id + "%' and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                    command += "name like '" + beneficiary.Name + "%' and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                    command += "abbr like '" + beneficiary.Abbr + "%' and ";
                command=command.Remove(command.Length - 5);
            }
            DataTable dataTable = DbHandler.getDataTable(command);
            List<Beneficiary> beneficiaryResultList = new List<Beneficiary>();
            List<T> a = new List<T>();
            
            //Beneficiary beneficiaryResult;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Beneficiary beneficiaryResult = new Beneficiary();
                beneficiaryResult.Id = dataRow["id"].ToString();
                beneficiaryResult.Name = dataRow["name"].ToString();
                beneficiaryResult.Abbr = dataRow["abbr"].ToString();
                beneficiaryResultList.Add(beneficiaryResult);
                T b = new T();
                b.Id = dataRow["id"].ToString();
                a.Add(b);
            }
            return a;
        }

        public Boolean update(Entity entity)
        {
            Beneficiary beneficiary = (Beneficiary)entity;
            antiSqlInjection(beneficiary);
            string command = "update beneficiary set ";
            if (0 > beneficiary.Id.Length)
                return false;
            command += "name='" + beneficiary.Name + "',abbr='" + beneficiary.Abbr + "' Where id='" + beneficiary.Id.Trim() + "'";

            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }

        public Boolean delete(Entity entity)
        {
            Beneficiary beneficiary = (Beneficiary)entity;
            if (beneficiary == null)
                return false;
            antiSqlInjection(beneficiary);
            string command = "delete from beneficiary where 1=1 and ";
            if (!string.IsNullOrWhiteSpace(beneficiary.Id))
                command += "id='" + beneficiary.Id + "' and ";
            if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                command += "name='" + beneficiary.Name + "' and ";
            if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                command += "abbr='" + beneficiary.Abbr + "' and ";
            command=command.Remove(command.Length - 5);

            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }

        
    }
}
