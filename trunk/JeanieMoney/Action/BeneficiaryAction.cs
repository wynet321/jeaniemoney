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
            string SQL = "insert into beneficiary values('" + beneficiary.Id + "','" + beneficiary.Name + "','" + beneficiary.Pinyin + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Beneficiary retrieveBeneficiaryById(string id)
        {
            string SQL = "select * from beneficiary where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Beneficiary beneficiary = new Beneficiary();
            beneficiary.Id = id;
            beneficiary.Name = dataTable.Rows[0]["name"].ToString();
            beneficiary.Pinyin = dataTable.Rows[0]["pinyin"].ToString();
            return beneficiary;
        }

        public List<Beneficiary> retrieveBeneficiaryList()
        {
            string SQL = "select * from beneficiary";
            List<Beneficiary> beneficiaryList = retrieveBeneficiaryListBySQL(SQL);
            return beneficiaryList;
        }

        public bool deleteBeneficiaryById(string id)
        {
            string SQL = "delete from beneficiary where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<Beneficiary> retrieveBeneficiaryListByPinyin(string pinyin)
        {
            string SQL = "select * from beneficiary where pinyin like '" + pinyin + "%'";
            List<Beneficiary> beneficiaryList = retrieveBeneficiaryListBySQL(SQL);
            return beneficiaryList;
        }

        public List<Beneficiary> retrieveBeneficiaryListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<Beneficiary> beneficiaryList = new List<Beneficiary>();
            Beneficiary beneficiary;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                beneficiary = new Beneficiary();
                beneficiary.Id = dataRow["id"].ToString();
                beneficiary.Name = dataRow["name"].ToString();
                beneficiary.Pinyin = dataRow["pinyin"].ToString();
                beneficiaryList.Add(beneficiary);
            }
            return beneficiaryList;
        }

        public bool updateBeneficiaryById(Beneficiary beneficiary)
        {
            string SQL = "update beneficiary set ";
            if (0 > beneficiary.Id.Length)
                return false;
            SQL += "name='" + beneficiary.Name + "',pinyin='" + beneficiary.Pinyin + "' Where id='" + beneficiary.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
