﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class Specification
    {
        private string id = "";
        public string Id { get { return id; } set { id = value; } }

        private string name = "";
        public string Name { get { return name; } set { name = value; } }

        private string pinyin = "";
        public string Pinyin { get { return pinyin; } set { pinyin = value; } }

    }
}
