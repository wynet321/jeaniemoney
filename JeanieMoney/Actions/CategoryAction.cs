using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using ClassLibrary.lib;
using System.Data;
using System.Data.Common;
using ClassLibrary.lib.Handler;

namespace JeanieMoney.Actions
{
    class CategoryAction:IAction<Category>
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Category category)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",category.Id,category.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", category.Name, category.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", category.Abbr, category.Abbr.GetType().Name),
                    dbHandler.generateDbParameter("@flag_in_out", category.IncomeOrOutgoing, category.IncomeOrOutgoing.GetType().Name),
                    dbHandler.generateDbParameter("@parent_id", category.ParentId, category.ParentId.GetType().Name)
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
        public bool create(Category category)
        {
            string command;
            if (String.IsNullOrEmpty(category.ParentId))
                command = "insert into category values(@id,@name,@abbr,@flag_in_out,null)";
            else
                command = "insert into category values(@id,@name,@abbr,@flag_in_out,@parent_id)";
            DbParameter[] dbParameterArray = generateDbParameterArray(category);
            if (1 == HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public bool update(Category category)
        {
            string command = "update category set ";
            if (!String.IsNullOrEmpty(category.Id))
                return false;
            if (!String.IsNullOrEmpty(category.Name))
                command += "name=@name,";
            if (!String.IsNullOrEmpty(category.Abbr))
                command += "abbr=@abbr,";
            if (!String.IsNullOrEmpty(category.ParentId))
                command += "parent_id=@parent_id";
            else
                command += "parent_id=null";

            command += " Where id=@id";
            DbParameter[] dbParameterArray = generateDbParameterArray(category);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public bool delete(Category category)
        {
            string command = "delete from category where id=@id";
            DbParameter[] dbParameterArray = generateDbParameterArray(category);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public Category retrieve(Category category)
        {
            string command = "select * from category where id=@id";
            DbParameter[] dbParameterArray = generateDbParameterArray(category);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            category = new Category();
            category.Id = dataTable.Rows[0]["id"].ToString();
            category.Name = dataTable.Rows[0]["name"].ToString();
            category.ParentId = dataTable.Rows[0]["parent_id"].ToString();
            category.Abbr = dataTable.Rows[0]["abbr"].ToString();
            category.IncomeOrOutgoing = ((bool)dataTable.Rows[0]["flag_in_out"]) ? '1' : '0';
            return category;
        }

        //public List<Category> retrieveList()
        //{
        //    string command = "select * from category";
        //    DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command);
        //    List<Category> categoryList = new List<Category>();
        //    Category category;
        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        category = new Category();
        //        category.Id = dataRow["id"].ToString();
        //        category.Name = dataRow["name"].ToString();
        //        category.IncomeOrOutgoing = ((bool)dataRow["flag_in_out"]) ? '1' : '0';
        //        category.Abbr = dataRow["abbr"].ToString();
        //        category.ParentId = dataRow["parent_id"].ToString();
        //        categoryList.Add(category);
        //    }
        //    return categoryList;
        //}

        public List<Category> retrieveList(Category category)
        {
            string command = "select * from category";
            if (category != null)
            {
                command += " where 1=1 and ";
                if (!string.IsNullOrWhiteSpace(category.Id))
                    command += "id=@id and ";
                if (!string.IsNullOrWhiteSpace(category.Name))
                    command += "name=@name and ";
                if (!string.IsNullOrWhiteSpace(category.Abbr))
                    command += "abbr=@abbr and ";
                if (category.IncomeOrOutgoing!='1'||category.IncomeOrOutgoing!='0')
                    command += "abbr=@flag_in_out and ";
                if (!string.IsNullOrWhiteSpace(category.ParentId))
                    command += "abbr=@parent_id and ";
                command = command.Remove(command.Length - 5);
            }
            DbParameter[] dbParameterArray = generateDbParameterArray(category);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Category> categoryList = new List<Category>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow["id"].ToString();
                category.Name = dataRow["name"].ToString();
                category.IncomeOrOutgoing = ((bool)dataRow["flag_in_out"]) ? '1' : '0';
                category.Abbr = dataRow["abbr"].ToString();
                category.ParentId = dataRow["parent_id"].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }

        //public List<Category> retrieveList(Boolean isIncome)
        //{
        //    string command = "select * from category";
        //    if (isIncome)
        //        command += " where flag_in_out='1'";
        //    else
        //        command += " where flag_in_out='0'";
        //    DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command);
        //    List<Category> categoryList = new List<Category>();
        //    Category category;
        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        category = new Category();
        //        category.Id = dataRow["id"].ToString();
        //        category.Name = dataRow["name"].ToString();
        //        category.IncomeOrOutgoing = ((bool)dataRow["flag_in_out"]) ? '1' : '0';
        //        category.Abbr = dataRow["abbr"].ToString();
        //        category.ParentId = dataRow["parent_id"].ToString();
        //        categoryList.Add(category);
        //    }
        //    return categoryList;
        //}

        //public List<Category> retrieveList(string parentId)
        //{
        //    string command = "select * from category where parent_id='" + parentId + "'";
        //    DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command);
        //    List<Category> categoryList = new List<Category>();
        //    Category category;
        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        category = new Category();
        //        category.Id = dataRow["id"].ToString();
        //        category.Name = dataRow["name"].ToString();
        //        category.ParentId = parentId;
        //        category.Abbr = dataRow["abbr"].ToString();
        //        category.IncomeOrOutgoing = ((bool)dataTable.Rows[0]["flag_in_out"]) ? '1' : '0';
        //        categoryList.Add(category);
        //    }
        //    return categoryList;
        //}

        //public List<Category> retrieveCategoryListByAbbr(string abbr)
        //{
        //    string command = "select * from category where abbr like '" + abbr + "%'";
        //    DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command);
        //    List<Category> categoryList = new List<Category>();
        //    Category category;
        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        category = new Category();
        //        category.Id = dataRow["id"].ToString();
        //        category.Name = dataRow["name"].ToString();
        //        category.ParentId = dataRow["parent_id"].ToString();
        //        category.Abbr = dataRow["abbr"].ToString();
        //        category.IncomeOrOutgoing = ((bool)dataRow["flag_in_out"]) ? '1' : '0';
        //        categoryList.Add(category);
        //    }
        //    return categoryList;
        //}

        public List<Category> retrieveCategoryListOfLeafNodeByAbbr(Category category)
        {
            string command = "select * from category where id not in (select distinct parent_id from category where parent_id is not null) and abbr like @abbr% and flag_in_out=@flag_in_out";
            DbParameter[] dbParameterArray = generateDbParameterArray(category);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Category> categoryList = new List<Category>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow["id"].ToString();
                category.Name = dataRow["name"].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }
    }
}
