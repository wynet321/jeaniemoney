using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entities
{
    class Product
    {
        private string id=String.Empty;
        public string Id { get { return id; } set { id = value; } }

        private string name =String.Empty;
        public string Name { get { return name; } set { name = value; } }

        private string abbr =String.Empty;
        public string Abbr { get { return abbr; } set { abbr = value; } }

        private string unitid =String.Empty;
        public string UnitId { get { return unitid; } set { unitid = value; } }

        private string unitquantity =String.Empty;
        public string UnitQuantity { get { return unitquantity; } set { unitquantity = value; } }

        private string manufactoryid =String.Empty;
        public string ManufactoryId { get { return manufactoryid; } set { manufactoryid = value; } }

        private string barcode = String.Empty;
        public string Barcode { get { return barcode; } set { barcode = value; } }
    }
}
