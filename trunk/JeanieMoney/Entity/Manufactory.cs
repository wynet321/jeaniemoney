﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class Manufactory
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string name ="";
        public string Name { get { return name; } set { name = value; } }

        private string abbr ="";
        public string Abbr { get { return abbr; } set { abbr = value; } }

        private string address ="";
        public string Address { get { return address; } set { address = value; } }

        private string tel ="";
        public string Tel { get { return tel; } set { tel = value; } }
    }
}
