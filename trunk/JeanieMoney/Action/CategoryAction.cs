using System;
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
                SQL = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Pinyin + "',null)";
            else
                SQL = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Pinyin + "','" + category.ParentId.Trim() + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public bool updateCategoryById(Category category)
        {
            string SQL = "update category set ";
            if (0 > category.Id.Length)
                return false;
            SQL += "name='" + category.Name + "',pinyin='" + category.Pinyin + "',";
            
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
            string SQL = "select id,name,parent_id,pinyin from category where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Category category = new Category();
            category.Id = id;
            category.Name = dataTable.Rows[0].ItemArray[1].ToString();
            category.ParentId = dataTable.Rows[0].ItemArray[2].ToString();
            category.Pinyin = dataTable.Rows[0].ItemArray[3].ToString();
            return category;
        }

        public List<Category> retrieveCategoryList()
        {
            string SQL = "select id,name from category";
            DataTable dataTable = Database.getDataTable(SQL);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow.ItemArray[0].ToString();
                category.Name = dataRow.ItemArray[1].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }

        public List<Category> retrieveCategoryListByParentId(string parentId)
        {
            string SQL = "select id,name,pinyin from category where parent_id='" + parentId + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow.ItemArray[0].ToString();
                category.Name = dataRow.ItemArray[1].ToString();
                category.ParentId = parentId;
                category.Pinyin = dataRow.ItemArray[2].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }

        public List<Category> retrieveCategoryListByPinyin(string pinyin)
        {
            string SQL = "select id,name,parent_id,pinyin from category where pinyin like '" + pinyin + "%'";
            DataTable dataTable = Database.getDataTable(SQL);
            List<Category> categoryList = new List<Category>();
            Category category;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category = new Category();
                category.Id = dataRow.ItemArray[0].ToString();
                category.Name = dataRow.ItemArray[1].ToString();
                category.ParentId = dataRow.ItemArray[2].ToString();
                category.Pinyin = dataRow.ItemArray[3].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }
    }
}
