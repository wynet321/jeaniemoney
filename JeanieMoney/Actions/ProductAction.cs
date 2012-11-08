using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JeanieMoney.Entities;
using ClassLibrary.lib;
using ClassLibrary.lib.Handler;
using System.Data.Common;

namespace JeanieMoney.Actions
{
    class ProductAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(Product product)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",product.Id,product.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", product.Name, product.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", product.Abbr, product.Abbr.GetType().Name),
                    dbHandler.generateDbParameter("@unitid", product.UnitId, product.UnitId.GetType().Name),
                    dbHandler.generateDbParameter("@unitquantity", product.UnitQuantity, product.UnitQuantity.GetType().Name),
                    dbHandler.generateDbParameter("@manufactoryid", product.ManufactoryId, product.ManufactoryId.GetType().Name),
                    dbHandler.generateDbParameter("@barcode", product.Barcode, product.Barcode.GetType().Name)
                    };
            return dbParameterArray;
        }
        public bool create(Product product)
        {
            string command = "insert into product values(@id,@name,@abbr,@unitid,@unitquantity,@manufactoryid,@barcode)";
            DbParameter[] dbParameterArray = generateDbParameterArray(product);
            if (1 == HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public Product retrieveProductById(Product product)
        {
            string command = "select * from product where id=@id";
            if (string.IsNullOrWhiteSpace(product.Id))
                return product;
            DbParameter[] dbParameterArray = generateDbParameterArray(product);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            product = new Product();
            product.Id = dataTable.Rows[0]["id"].ToString();
            product.Name = dataTable.Rows[0]["name"].ToString();
            product.Abbr = dataTable.Rows[0]["abbr"].ToString();
            product.Barcode = dataTable.Rows[0]["barcode"].ToString();
            product.UnitId = dataTable.Rows[0]["unit_id"].ToString();
            product.UnitQuantity = dataTable.Rows[0]["unit_quantity"].ToString();
            product.ManufactoryId = dataTable.Rows[0]["manufactory_id"].ToString();
            return product;
        }

        //public List<Product> retrieveProductList()
        //{
        //    string command = "select * from product";
        //    List<Product> productList = retrieveProductListBySQL(command);
        //    return productList;
        //}

        public bool delete(Product product)
        {
            string command = "delete from product where id=@id";
            if (string.IsNullOrWhiteSpace(product.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(product);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<Product> retrieveProductListByAbbr(string abbr)
        //{
        //    string command = "select * from product where abbr like '" + abbr + "%'";
        //    List<Product> productList = retrieveProductListBySQL(command);
        //    return productList;
        //}

        public List<Product> retrieveList(Product product)
        {
            string command = "select * from product";
            if (string.IsNullOrWhiteSpace(product.Id))
                command += " where abbr like @abbr%";
            DbParameter[] dbParameterArray = generateDbParameterArray(product);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<Product> productList = new List<Product>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                product = new Product();
                product.Id = dataRow["id"].ToString();
                product.Name = dataRow["name"].ToString();
                product.Abbr = dataRow["abbr"].ToString();
                product.Barcode = dataRow["barcode"].ToString();
                product.UnitId = dataRow["unit_id"].ToString();
                product.UnitQuantity = dataRow["unit_quantity"].ToString();
                product.ManufactoryId = dataRow["manufactory_id"].ToString();
                productList.Add(product);
            }
            return productList;
        }

        public bool updateProductById(Product product)
        {
            string command = "update product set name=@name,abbr=@abbr,barcode=@barcode, unit_id=@unitid,unit_quantity=@unitquantity,manufactory_id=@manufactoryid Where id=@id";
            if (0 > product.Id.Length)
                return false;
            if (string.IsNullOrWhiteSpace(product.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(product);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }
}
