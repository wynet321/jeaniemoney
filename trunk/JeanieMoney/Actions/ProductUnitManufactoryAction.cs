using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Utility;
using System.Data;
using JeanieMoney.Entities;

namespace JeanieMoney.Actions
{
    class ProductUnitManufactoryAction
    {
        
        public List<ProductUnitManufactory> retrieveProductUnitListByAbbr(string abbr)
        {
            string command = "select * from product_unit_manufactory where abbr like'" + abbr + "%'";
            List<ProductUnitManufactory> productUnitManufactoryList = retrieveProductListBySQL(command);
            return productUnitManufactoryList;
        }

        public List<ProductUnitManufactory> retrieveProductListBySQL(string command)
        {
            DataTable dataTable = DbHandler.getDataTable(command);
            List<ProductUnitManufactory> productUnitManufactoryList = new List<ProductUnitManufactory>();
            ProductUnitManufactory productUnitManufactory;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                productUnitManufactory = new ProductUnitManufactory();
                productUnitManufactory.Id = dataRow["id"].ToString();
                productUnitManufactory.Name = dataRow["name"].ToString();
                productUnitManufactory.Abbr = dataRow["abbr"].ToString();
                productUnitManufactory.Unit = dataRow["unit_name"].ToString();
                productUnitManufactory.UnitId = dataRow["unit_id"].ToString();
                productUnitManufactory.NameUnit = dataRow["name_unit"].ToString();
                productUnitManufactory.ManufactoryId = dataRow["manufactory_id"].ToString();
                productUnitManufactory.ManufactoryName = dataRow["manufactory_name"].ToString();
                productUnitManufactory.Address = dataRow["address"].ToString();
                productUnitManufactory.Tel = dataRow["tel"].ToString();
                productUnitManufactoryList.Add(productUnitManufactory);
            }
            return productUnitManufactoryList;
        }
    }
}
