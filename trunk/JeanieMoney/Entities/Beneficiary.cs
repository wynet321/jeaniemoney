using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entities
{
    class Beneficiary
    {
        private String id;
        public String Id { get { return id; } set { id = value; } }

        private String name = String.Empty;
        public String Name { get { return name; } set { name = value; } }

        private String abbr = String.Empty;
        public String Abbr { get { return abbr; } set { abbr = value; } }
    }
}
