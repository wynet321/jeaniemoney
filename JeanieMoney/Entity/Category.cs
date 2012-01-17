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

        private string name ="";
        public string Name { get { return name; } set { name = value; } }

        private string pinyin ="";
        public string Pinyin { get { return pinyin; } set { pinyin = value; } }

        private char inorout ="";
        public char InOrOut { get { return inorout; } set { inorout = value; } }

        private string parentId ="";
        public string ParentId { get { return parentId; } set { parentId = value; } }

        
    }
}
