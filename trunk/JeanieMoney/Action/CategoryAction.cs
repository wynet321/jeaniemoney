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
            string SQL = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Pinyin + "','" + category.ParentId + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public bool updateCategoryById(Category category)
        {
            string SQL = "update category set ";
            if (0 < category.Id.Length)
                return false;
            if (0 < category.Name.Length)
                SQL += "name='" + category.Name + "',";
            if (0 < category.ParentId.Length)
                SQL += "parent_id='" + category.ParentId + "',";
            if (0 < category.Pinyin.Length)
                SQL += "pinyin='" + category.Pinyin + "'";
            SQL += " Where id='" + category.Id + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public bool deleteCategoryById(Category category)
        {
            string SQL = "delete from category where id='" + category.Id + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Category retriveCategoryById(string id)
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

        public List<Category> retrieveCategoryListByParentId(string parentId)
        {
            string SQL = "select id,name,pinyin from category where parent_id='" + parentId + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            List<Category> categoryList = new List<Category>();
            Category category = new Category();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                category.Id = dataRow.ItemArray[0].ToString();
                category.Name = dataRow.ItemArray[1].ToString();
                category.ParentId = parentId;
                category.Pinyin = dataRow.ItemArray[2].ToString();
                categoryList.Add(category);
            }
            return categoryList;
        }
    }
}
