using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Utility;
using System.Data;
using JeanieMoney.Entity;

namespace JeanieMoney.Action
{
    class ProductAction
    {
        public bool createProduct(Product product)
        {
            string SQL = "insert into product values('" + product.Id + "','" + product.Name + "','" + product.Abbr + "','" + product.SpecificationId + "','" + product.SpecificationQuantity + "','" + product.ManufactoryId + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Product retrieveProductById(string id)
        {
            string SQL = "select * from product where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Product product = new Product();
            product.Id = id;
            product.Name = dataTable.Rows[0]["name"].ToString();
            product.Abbr = dataTable.Rows[0]["abbr"].ToString();
            product.SpecificationId = dataTable.Rows[0]["specification_id"].ToString();
            product.SpecificationQuantity = dataTable.Rows[0]["specification_quantity"].ToString();
            product.ManufactoryId = dataTable.Rows[0]["manufactory_id"].ToString();
            return product;
        }

        public List<Product> retrieveProductList()
        {
            string SQL = "select * from product";
            List<Product> productList = retrieveProductListBySQL(SQL);
            return productList;
        }

        public bool deleteProductById(string id)
        {
            string SQL = "delete from product where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<Product> retrieveProductListByAbbr(string abbr)
        {
            string SQL = "select * from product where abbr like '" + abbr + "%'";
            List<Product> productList = retrieveProductListBySQL(SQL);
            return productList;
        }

        public List<Product> retrieveProductListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<Product> productList = new List<Product>();
            Product product;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                product = new Product();
                product.Id = dataRow["id"].ToString();
                product.Name = dataRow["name"].ToString();
                product.Abbr = dataRow["abbr"].ToString();
                product.SpecificationId = dataRow["specification_id"].ToString();
                product.SpecificationQuantity = dataRow["specification_quantity"].ToString();
                product.ManufactoryId = dataRow["manufactory_id"].ToString();
                productList.Add(product);
            }
            return productList;
        }

        public bool updateProductById(Product product)
        {
            string SQL = "update product set ";
            if (0 > product.Id.Length)
                return false;
            SQL += "name='" + product.Name + "',abbr='" + product.Abbr + "'," + "specification_id='" + product.SpecificationId + "',specification_quantity='" + product.SpecificationQuantity + "',manufactory_id='" + product.ManufactoryId + "' Where id='" + product.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
