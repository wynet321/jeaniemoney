using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Utility;
using JeanieMoney.Entities;
using System.Data;

namespace JeanieMoney.Actions
{
    class BeneficiaryAction
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
        public bool create(Beneficiary beneficiary)
        {
            antiSqlInjection(beneficiary);
            string command = "insert into beneficiary values('" + beneficiary.Id + "','" + beneficiary.Name + "','" + beneficiary.Abbr + "')";
            if (1 == DbHandler.execCommand(command))
                return true;
            return false;
        }

        public Beneficiary retrieve(Beneficiary beneficiary)
        {
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

        public List<Beneficiary> retrieveList(Beneficiary beneficiary)
        {
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
            //Beneficiary beneficiaryResult;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Beneficiary beneficiaryResult = new Beneficiary();
                beneficiaryResult.Id = dataRow["id"].ToString();
                beneficiaryResult.Name = dataRow["name"].ToString();
                beneficiaryResult.Abbr = dataRow["abbr"].ToString();
                beneficiaryResultList.Add(beneficiaryResult);
            }
            return beneficiaryResultList;
        }

        public bool update(Beneficiary beneficiary)
        {
            antiSqlInjection(beneficiary);
            string command = "update beneficiary set ";
            if (0 > beneficiary.Id.Length)
                return false;
            command += "name='" + beneficiary.Name + "',abbr='" + beneficiary.Abbr + "' Where id='" + beneficiary.Id.Trim() + "'";

            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }

        public bool delete(Beneficiary beneficiary)
        {
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
