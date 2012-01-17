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

        private string pinyin ="";
        public string Pinyin { get { return pinyin; } set { pinyin = value; } }

        private string specificationid ="";
        public string SpecificationId { get { return specificationid; } set { specificationid = value; } }

        private string specificationquantity ="";
        public string SpecificationQuantity { get { return specificationquantity; } set { specificationquantity = value; } }

        private string manufactoryid ="";
        public string ManufactoryId { get { return manufactoryid; } set { manufactoryid = value; } }
    }
}
