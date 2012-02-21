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
        
        public List<ProductSpecificationManufactory> retrieveProductSpecificationListByAbbr(string abbr)
        {
            string command = "select * from product_specification_manufactory where abbr like'" + abbr + "%'";
            List<ProductSpecificationManufactory> productSpecificationManufactoryList = retrieveProductListBySQL(command);
            return productSpecificationManufactoryList;
        }

        public List<ProductSpecificationManufactory> retrieveProductListBySQL(string command)
        {
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            List<ProductSpecificationManufactory> productSpecificationManufactoryList = new List<ProductSpecificationManufactory>();
            ProductSpecificationManufactory productSpecificationManufactory;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                productSpecificationManufactory = new ProductSpecificationManufactory();
                productSpecificationManufactory.Id = dataRow["id"].ToString();
                productSpecificationManufactory.Name = dataRow["name"].ToString();
                productSpecificationManufactory.Abbr = dataRow["abbr"].ToString();
                productSpecificationManufactory.Specification = dataRow["specification_name"].ToString();
                productSpecificationManufactory.SpecificationId = dataRow["specification_id"].ToString();
                productSpecificationManufactory.NameSpecification = dataRow["name_specification"].ToString();
                productSpecificationManufactory.ManufactoryId = dataRow["manufactory_id"].ToString();
                productSpecificationManufactory.ManufactoryName = dataRow["manufactory_name"].ToString();
                productSpecificationManufactory.Address = dataRow["address"].ToString();
                productSpecificationManufactory.Tel = dataRow["tel"].ToString();
                productSpecificationManufactoryList.Add(productSpecificationManufactory);
            }
            return productSpecificationManufactoryList;
        }
    }
}
