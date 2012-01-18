using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Utility;
using System.Data;
using JeanieMoney.Entity;

namespace JeanieMoney.Action
{
    class ProductSpecificationManufactoryAction
    {
        
        public List<ProductSpecificationManufactory> retrieveProductSpecificationListByPinyin(string pinyin)
        {
            string SQL = "select * from product_specification_manufactory where pinyin like'" + pinyin + "%'";
            List<ProductSpecificationManufactory> productSpecificationManufactoryList = retrieveProductListBySQL(SQL);
            return productSpecificationManufactoryList;
        }

        public List<ProductSpecificationManufactory> retrieveProductListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<ProductSpecificationManufactory> productSpecificationManufactoryList = new List<ProductSpecificationManufactory>();
            ProductSpecificationManufactory productSpecificationManufactory;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                productSpecificationManufactory = new ProductSpecificationManufactory();
                productSpecificationManufactory.Id = dataTable.Rows[0]["id"].ToString();
                productSpecificationManufactory.Name = dataTable.Rows[0]["name"].ToString();
                productSpecificationManufactory.Pinyin = dataTable.Rows[0]["pinyin"].ToString();
                productSpecificationManufactory.Specification = dataTable.Rows[0]["specification"].ToString();
                productSpecificationManufactory.SpecificationId = dataTable.Rows[0]["specificationid"].ToString();
                productSpecificationManufactory.NameSpecification = dataTable.Rows[0]["namespecification"].ToString();
                productSpecificationManufactory.ManufactoryId = dataTable.Rows[0]["manufactoryid"].ToString();
                productSpecificationManufactory.ManufactoryName = dataTable.Rows[0]["manufactoryname"].ToString();
                productSpecificationManufactory.Address = dataTable.Rows[0]["address"].ToString();
                productSpecificationManufactory.Tel = dataTable.Rows[0]["tel"].ToString();
                productSpecificationManufactoryList.Add(productSpecificationManufactory);
            }
            return productSpecificationManufactoryList;
        }
    }
}
