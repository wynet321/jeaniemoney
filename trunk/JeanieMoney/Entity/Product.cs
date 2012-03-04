using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class Product
    {
        private string id="";
        public string Id { get { return id; } set { id = value; } }

        private string name ="";
        public string Name { get { return name; } set { name = value; } }

        private string abbr ="";
        public string Abbr { get { return abbr; } set { abbr = value; } }

        private string unitid ="";
        public string UnitId { get { return unitid; } set { unitid = value; } }

        private string unitquantity ="";
        public string UnitQuantity { get { return unitquantity; } set { unitquantity = value; } }

        private string manufactoryid ="";
        public string ManufactoryId { get { return manufactoryid; } set { manufactoryid = value; } }

        private string barcode = "";
        public string Barcode { get { return barcode; } set { barcode = value; } }
    }
}
