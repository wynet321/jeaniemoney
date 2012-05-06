using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class Location
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string name =String.Empty;
        public string Name { get { return name; } set { name = value; } }

        private string abbr =String.Empty;
        public string Abbr { get { return abbr; } set { abbr = value; } }
    }
}
