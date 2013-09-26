using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JeanieMoney.Entities;
using ClassLibrary.lib;
using System.Data.Common;
using ClassLibrary.lib.Handler;

namespace JeanieMoney.Actions
{
    class ProductUnitManufactoryAction
    {
        private DbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(ProductUnitManufactory productUnitManufactory)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",productUnitManufactory.Id,productUnitManufactory.Id.GetType().Name),
                    dbHandler.generateDbParameter("@unitid", productUnitManufactory.UnitId, productUnitManufactory.UnitId.GetType().Name),
                    dbHandler.generateDbParameter("@manufactoryid", productUnitManufactory.ManufactoryId, productUnitManufactory.ManufactoryId.GetType().Name),
                    dbHandler.generateDbParameter("@name", productUnitManufactory.Name, productUnitManufactory.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", productUnitManufactory.Abbr, productUnitManufactory.Abbr.GetType().Name),
                    dbHandler.generateDbParameter("@unit", productUnitManufactory.Unit, productUnitManufactory.Unit.GetType().Name),
                    dbHandler.generateDbParameter("@nameunit", productUnitManufactory.NameUnit, productUnitManufactory.NameUnit.GetType().Name),
                    dbHandler.generateDbParameter("@manufactoryname", productUnitManufactory.ManufactoryName, productUnitManufactory.ManufactoryName.GetType().Name),
                    dbHandler.generateDbParameter("@address", productUnitManufactory.Address, productUnitManufactory.Address.GetType().Name),
                    dbHandler.generateDbParameter("@tel", productUnitManufactory.Tel, productUnitManufactory.Tel.GetType().Name)
                    };
            return dbParameterArray;
        }

        //public List<ProductUnitManufactory> retrieveProductUnitListByAbbr(string abbr)
        //{
        //    string command = "select * from product_unit_manufactory where abbr like'" + abbr + "%'";
        //    List<ProductUnitManufactory> productUnitManufactoryList = retrieveProductListBySQL(command);
        //    return productUnitManufactoryList;
        //}

        public List<ProductUnitManufactory> retrieveList(ProductUnitManufactory productUnitManufactory)
        {
            string command = "select * from product_unit_manufactory";
            if (string.IsNullOrWhiteSpace(productUnitManufactory.Abbr))
                command += " where abbr like @abbr%";
            DbParameter[] dbParameterArray = generateDbParameterArray(productUnitManufactory);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<ProductUnitManufactory> productUnitManufactoryList = new List<ProductUnitManufactory>();
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
