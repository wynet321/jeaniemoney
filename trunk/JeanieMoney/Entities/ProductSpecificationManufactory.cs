using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entities
{
    class ProductUnitManufactory
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string unitid;
        public string UnitId { get { return unitid; } set { unitid = value; } }

        private string manufactoryid;
        public string ManufactoryId { get { return manufactoryid; } set { manufactoryid = value; } }

        private string name = String.Empty;
        public string Name { get { return name; } set { name = value; } }

        private string abbr = String.Empty;
        public string Abbr { get { return abbr; } set { abbr = value; } }

        private string unit = String.Empty;
        public string Unit { get { return unit; } set { unit = value; } }

        private string nameunit = String.Empty;
        public string NameUnit { get { return nameunit; } set { nameunit = value; } }

        private string manufactoryname = String.Empty;
        public string ManufactoryName { get { return manufactoryname; } set { manufactoryname = value; } }
        
        private string address = String.Empty;
        public string Address { get { return address; } set { address = value; } }

        private string tel = String.Empty;
        public string Tel { get { return tel; } set { tel = value; } }
    }
}
