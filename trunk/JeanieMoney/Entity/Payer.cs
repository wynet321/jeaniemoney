using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class Payer
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string name ="";
        public string Name { get { return name; } set { name = value; } }

        private string abbr ="";
        public string Abbr { get { return abbr; } set { abbr = value; } }
    }
}
