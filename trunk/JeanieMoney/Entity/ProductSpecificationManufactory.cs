using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class ProductSpecificationManufactory
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        private string specificationid;
        public string SpecificationId { get { return specificationid; } set { specificationid = value; } }

        private string manufactoryid;
        public string ManufactoryId { get { return manufactoryid; } set { manufactoryid = value; } }

        private string name = "";
        public string Name { get { return name; } set { name = value; } }

        private string pinyin = "";
        public string Pinyin { get { return pinyin; } set { pinyin = value; } }

        private string specification = "";
        public string Specification { get { return specification; } set { specification = value; } }

        private string namespecification = "";
        public string NameSpecification { get { return namespecification; } set { namespecification = value; } }

        private string manufactoryname = "";
        public string ManufactoryName { get { return manufactoryname; } set { manufactoryname = value; } }
        
        private string address = "";
        public string Address { get { return address; } set { address = value; } }

        private string tel = "";
        public string Tel { get { return tel; } set { tel = value; } }
    }
}
