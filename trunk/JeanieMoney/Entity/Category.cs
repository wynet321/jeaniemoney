using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class Category
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string name { get; set; }
        public string Name { get { return name; } set { name = value; } }

        private string pinyin { get; set; }
        public string Pinyin { get { return pinyin; } set { pinyin = value; } }

        private string parent_id { get; set; }
        public string Parent_id { get { return parent_id; } set { parent_id = value; } }
    }
}
