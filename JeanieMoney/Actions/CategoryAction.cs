using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Actions
{
    class CategoryAction
    {
        public bool createCategory(Category category)
        {
            string command;
            if (String.IsNullOrEmpty(category.ParentId))
                command = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Abbr + "','" + category.IncomeOrOutgoing + "',null)";
            else
                command = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Abbr + "','" + category.IncomeOrOutgoing + "','" + category.ParentId.Trim() + "')";
            if (1 == DbHandler.execCommand(command))
                return true;
            return false;
        }

        public bool updateCategoryById(Category category)
        {
            string command = "update category set ";
            if (!String.IsNullOrEmpty(category.Id))
                return false;
            if (!String.IsNullOrEmpty(category.Name))
                command += "name='" + category.Name + "',";
            if (!String.IsNullOrEmpty(category.Abbr))
                command += "abbr='" + category.Abbr + "',";
            if (!String.IsNullOrEmpty(category.ParentId))
                command += "parent_id='" + category.ParentId.Trim() + "'";
            else
                command += "parent_id=null";

            command += " Where id='" + category.Id.Trim() + "'";

            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }

        public bool deleteCategoryById(string id)
        {
            string command = "delete from category where id='" + id + "'";
            if (0 < DbHandler.execCommand(command))
                return true;
            return false;
        }

        public Category retrieveCategoryById(string id)
        {
            string command = "select * from category where id='" + id + "'";
            DataTable dataTable = DbHandler.getDataTable(command);
            Category category = new Category();
            category.Id = id;
            category.Name = dataTable.Rows[0]["name"].ToString();
            category.ParentId = dataTable.Rows[0]["parent_id"].ToString();
            category.Abbr = dataTable.Rows[0]["abbr"].ToString();
            category.IncomeOrOutgoing = ((bool)dataTable.Rows[0]["flag_in_out"]) ? '1' : '0';
            return category;
        }

        public List<Category> retrieveCategoryList()
        {
            string command = "select * from category";
            DataTable dataTable = DbHandler.getDataTable(command);
            List<Category> categoryList = new List<Category>();
            Category category;
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

        public List<Category> retrieveCategoryList(Boolean isIncome)
        {
            string command = "select * from category";
            if (isIncome)
                command += " where flag_in_out='1'";
            else
                command += " where flag_in_out='0'";
            DataTable dataTable = DbHandler.getDataTable(command);
            List<Category> categoryList = new List<Category>();
            Category category;
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

        public List<Category> retrieveCategoryListByParentId(string parentId)
        {
            string command = "select * from category where parent_id='" + parentId + "'";
            DataTable dataTable = DbHandler.getDataTable(command);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow["id"].ToString();
                category.Name = dataRow["name"].ToString();
                category.ParentId = parentId;
                category.Abbr = dataRow["abbr"].ToString();
                category.IncomeOrOutgoing = ((bool)dataTable.Rows[0]["flag_in_out"]) ? '1' : '0';
                categoryList.Add(category);
            }
            return categoryList;
        }

        public List<Category> retrieveCategoryListByAbbr(string abbr)
        {
            string command = "select * from category where abbr like '" + abbr + "%'";
            DataTable dataTable = DbHandler.getDataTable(command);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow["id"].ToString();
                category.Name = dataRow["name"].ToString();
                category.ParentId = dataRow["parent_id"].ToString();
                category.Abbr = dataRow["abbr"].ToString();
                category.IncomeOrOutgoing = ((bool)dataRow["flag_in_out"]) ? '1' : '0';
                categoryList.Add(category);
            }
            return categoryList;
        }

        public List<Category> retrieveCategoryListOfLeafNodeByAbbr(string abbr, char inorout)
        {
            string command = "select * from category where id not in (select distinct parent_id from category where parent_id is not null) and abbr like '" + abbr + "%' and flag_in_out='" + inorout + "'";
            DataTable dataTable = DbHandler.getDataTable(command);
            List<Category> categoryList = new List<Category>();
            Category category;
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
