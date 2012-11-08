using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entities
{
    class Unit
    {
        private string id = String.Empty;
        public string Id { get { return id; } set { id = value; } }

        private string name = String.Empty;
        public string Name { get { return name; } set { name = value; } }

        private string abbr = String.Empty;
        public string Abbr { get { return abbr; } set { abbr = value; } }

    }
}
