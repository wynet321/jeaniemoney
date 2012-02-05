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
            string command = "insert into product values('" + product.Id + "','" + product.Name + "','" + product.Abbr + "','" + product.SpecificationId + "','" + product.SpecificationQuantity + "','" + product.ManufactoryId + "')";
            if (1==Database.execCommand(command))
                return true;
            return false;
        }

        public Product retrieveProductById(string id)
        {
            string command = "select * from product where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(command);
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
            string command = "select * from product";
            List<Product> productList = retrieveProductListBySQL(command);
            return productList;
        }

        public bool deleteProductById(string id)
        {
            string command = "delete from product where id='" + id + "'";
            if (0 < Database.execCommand(command))
                return true;
            return false;
        }
        public List<Product> retrieveProductListByAbbr(string abbr)
        {
            string command = "select * from product where abbr like '" + abbr + "%'";
            List<Product> productList = retrieveProductListBySQL(command);
            return productList;
        }

        public List<Product> retrieveProductListBySQL(string command)
        {
            DataTable dataTable = Database.getDataTable(command);
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
            string command = "update product set ";
            if (0 > product.Id.Length)
                return false;
            command += "name='" + product.Name + "',abbr='" + product.Abbr + "'," + "specification_id='" + product.SpecificationId + "',specification_quantity='" + product.SpecificationQuantity + "',manufactory_id='" + product.ManufactoryId + "' Where id='" + product.Id.Trim() + "'";

            if (0 < Database.execCommand(command))
                return true;
            return false;
        }
    }
}
