using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Utility;
using JeanieMoney.Entity;
using System.Data;

namespace JeanieMoney.Action
{
    class BeneficiaryAction
    {
        public bool createBeneficiary(Beneficiary beneficiary)
        {
            string command = "insert into beneficiary values('" + beneficiary.Id + "','" + beneficiary.Name + "','" + beneficiary.Abbr + "')";
            if (1== JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }

        public Beneficiary retrieveBeneficiaryById(string id)
        {
            string command = "select * from beneficiary where id='" + id + "'";
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            Beneficiary beneficiary = new Beneficiary();
            beneficiary.Id = id;
            beneficiary.Name = dataTable.Rows[0]["name"].ToString();
            beneficiary.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return beneficiary;
        }

        public List<Beneficiary> retrieveBeneficiaryList()
        {
            string command = "select * from beneficiary";
            List<Beneficiary> beneficiaryList = retrieveBeneficiaryListBySQL(command);
            return beneficiaryList;
        }

        public bool deleteBeneficiaryById(string id)
        {
            string command = "delete from beneficiary where id='" + id + "'";
            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
        public List<Beneficiary> retrieveBeneficiaryListByAbbr(string abbr)
        {
            string command = "select * from beneficiary where abbr like '" + abbr + "%'";
            List<Beneficiary> beneficiaryList = retrieveBeneficiaryListBySQL(command);
            return beneficiaryList;
        }

        public List<Beneficiary> retrieveBeneficiaryListBySQL(string command)
        {
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            List<Beneficiary> beneficiaryList = new List<Beneficiary>();
            Beneficiary beneficiary;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                beneficiary = new Beneficiary();
                beneficiary.Id = dataRow["id"].ToString();
                beneficiary.Name = dataRow["name"].ToString();
                beneficiary.Abbr = dataRow["abbr"].ToString();
                beneficiaryList.Add(beneficiary);
            }
            return beneficiaryList;
        }

        public bool updateBeneficiaryById(Beneficiary beneficiary)
        {
            string command = "update beneficiary set ";
            if (0 > beneficiary.Id.Length)
                return false;
            command += "name='" + beneficiary.Name + "',abbr='" + beneficiary.Abbr + "' Where id='" + beneficiary.Id.Trim() + "'";

            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
    }
}
