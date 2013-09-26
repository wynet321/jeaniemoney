using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using System.Data;
using ClassLibrary.lib.Handler;
using System.Data.Common;
using ClassLibrary.lib;

namespace JeanieMoney.Actions
{
    class BeneficiaryAction:IAction<Beneficiary>
    {
        private DbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Beneficiary beneficiary)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",beneficiary.Id,beneficiary.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", beneficiary.Name, beneficiary.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", beneficiary.Abbr, beneficiary.Abbr.GetType().Name),
            };
            return dbParameterArray;
        }
        
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
            string command = "insert into beneficiary values(@id,@name,@abbr)";
            DbParameter[] dbParameterArray = generateDbParameterArray(beneficiary);
            if (1 == HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
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
                    command += "id=@id and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                    command += "name=@name and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                    command += "abbr=@abbr and ";
                command=command.Remove(command.Length - 5);
            }
            DbParameter[] dbParameterArray = generateDbParameterArray(beneficiary);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
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
                    command += "id like @id% and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                    command += "name like @name% and ";
                if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                    command += "abbr like @abbr% and ";
                command=command.Remove(command.Length - 5);
            }
            DbParameter[] dbParameterArray = generateDbParameterArray(beneficiary);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
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
            string command = "update beneficiary set name=@name,abbr=@abbr Where id=@id";
            DbParameter[] dbParameterArray = generateDbParameterArray(beneficiary);
            if (0 > beneficiary.Id.Length)
                return false;
            
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
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
                command += "id=@id and ";
            if (!string.IsNullOrWhiteSpace(beneficiary.Name))
                command += "name=@name and ";
            if (!string.IsNullOrWhiteSpace(beneficiary.Abbr))
                command += "abbr=@abbr and ";
            command=command.Remove(command.Length - 5);
            DbParameter[] dbParameterArray = generateDbParameterArray(beneficiary);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }
}
