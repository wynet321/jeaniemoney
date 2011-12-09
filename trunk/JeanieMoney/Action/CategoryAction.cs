using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;

namespace JeanieMoney.Action
{
    class CategoryAction
    {
        public bool createCategory(Category category)
        {
            string SQL = "insert into category values('" + category.Id + "','" + category.Name + "','" + category.Pinyin + "','" + category.Parent_id + "')";
            return true;
        }
    }
}
