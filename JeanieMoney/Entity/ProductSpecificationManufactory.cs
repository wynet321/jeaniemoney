using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class ProductUnitManufactory
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string unitid;
        public string UnitId { get { return unitid; } set { unitid = value; } }

        private string manufactoryid;
        public string ManufactoryId { get { return manufactoryid; } set { manufactoryid = value; } }

        private string name = "";
        public string Name { get { return name; } set { name = value; } }

        private string abbr = "";
        public string Abbr { get { return abbr; } set { abbr = value; } }

        private string unit = "";
        public string Unit { get { return unit; } set { unit = value; } }

        private string nameunit = "";
        public string NameUnit { get { return nameunit; } set { nameunit = value; } }

        private string manufactoryname = "";
        public string ManufactoryName { get { return manufactoryname; } set { manufactoryname = value; } }
        
        private string address = "";
        public string Address { get { return address; } set { address = value; } }

        private string tel = "";
        public string Tel { get { return tel; } set { tel = value; } }
    }
}
