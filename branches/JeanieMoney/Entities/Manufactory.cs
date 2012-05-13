using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entities
{
    class Manufactory
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string name =String.Empty;
        public string Name { get { return name; } set { name = value; } }

        private string abbr =String.Empty;
        public string Abbr { get { return abbr; } set { abbr = value; } }

        private string address =String.Empty;
        public string Address { get { return address; } set { address = value; } }

        private string tel =String.Empty;
        public string Tel { get { return tel; } set { tel = value; } }
    }
}
