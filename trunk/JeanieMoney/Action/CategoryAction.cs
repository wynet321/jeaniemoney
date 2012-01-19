﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class CategoryAction
    {
        public bool createCategory(Category category)
        {
            string SQL;
            if (null == category.ParentId)
                SQL = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Abbr + "','" + category.InOrOut + "',null)";
            else
                SQL = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Abbr + "','" + category.InOrOut + "','" + category.ParentId.Trim() + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public bool updateCategoryById(Category category)
        {
            string SQL = "update category set ";
            if (0 > category.Id.Length)
                return false;
            SQL += "name='" + category.Name + "',abbr='" + category.Abbr + "',flag_in_out='" + category.InOrOut + "',";

            if (null != category.ParentId)
                SQL += "parent_id='" + category.ParentId.Trim() + "'";
            else
                SQL += "parent_id=null";

            SQL += " Where id='" + category.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public bool deleteCategoryById(string id)
        {
            string SQL = "delete from category where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Category retrieveCategoryById(string id)
        {
            string SQL = "select * from category where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Category category = new Category();
            category.Id = id;
            category.Name = dataTable.Rows[0]["name"].ToString();
            category.ParentId = dataTable.Rows[0]["parent_id"].ToString();
            category.Abbr = dataTable.Rows[0]["abbr"].ToString();
            category.InOrOut = ((bool)dataTable.Rows[0]["flag_in_out"]) ? '1' : '0';
            return category;
        }

        public List<Category> retrieveCategoryList()
        {
            string SQL = "select * from category";
            DataTable dataTable = Database.getDataTable(SQL);
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

        public List<Category> retrieveCategoryListByParentId(string parentId)
        {
            string SQL = "select * from category where parent_id='" + parentId + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow["id"].ToString();
                category.Name = dataRow["name"].ToString();
                category.ParentId = parentId;
                category.Abbr = dataRow["abbr"].ToString();
                category.InOrOut = ((bool)dataTable.Rows[0]["flag_in_out"]) ? '1' : '0';
                categoryList.Add(category);
            }
            return categoryList;
        }

        public List<Category> retrieveCategoryListByAbbr(string abbr)
        {
            string SQL = "select * from category where abbr like '" + abbr + "%'";
            DataTable dataTable = Database.getDataTable(SQL);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow["id"].ToString();
                category.Name = dataRow["name"].ToString();
                category.ParentId = dataRow["parent_id"].ToString();
                category.Abbr = dataRow["abbr"].ToString();
                category.InOrOut = ((bool)dataRow["flag_in_out"]) ? '1' : '0';
                categoryList.Add(category);
            }
            return categoryList;
        }

        public List<Category> retrieveCategoryListOfLeafNodeByAbbr(string abbr, char inorout)
        {
            string SQL = "select * from category where id not in (select distinct parent_id from category where parent_id is not null) and abbr like '" + abbr + "%' and flag_in_out='" + inorout + "'";
            DataTable dataTable = Database.getDataTable(SQL);
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
