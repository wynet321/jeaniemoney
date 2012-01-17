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
            string SQL = "insert into product values('" + product.Id + "','" + product.Name + "','" + product.Pinyin + "','" + product.SpecificationId + "','" + product.SpecificationQuantity + "','" + product.ManufactoryId + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public Product retrieveProductById(string id)
        {
            string SQL = "select id,name,pinyin,specification_id,specification_quantity,manufactory_id from product where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            Product product = new Product();
            product.Id = id;
            product.Name = dataTable.Rows[0].ItemArray[1].ToString();
            product.Pinyin = dataTable.Rows[0].ItemArray[2].ToString();
            product.SpecificationId = dataTable.Rows[0].ItemArray[3].ToString();
            product.SpecificationQuantity = dataTable.Rows[0].ItemArray[4].ToString();
            product.ManufactoryId = dataTable.Rows[0].ItemArray[5].ToString();
            return product;
        }

        public List<Product> retrieveProductList()
        {
            string SQL = "select id,name,pinyin,specification_id,specification_quantity,manufactory_id from product";
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
        public List<Product> retrieveProductListByPinyin(string pinyin)
        {
            string SQL = "select id,name,pinyin,specification_id,specification_quantity,manufactory_id from product where pinyin like '" + pinyin + "%'";
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
                product.Id = dataRow.ItemArray[0].ToString();
                product.Name = dataRow.ItemArray[1].ToString();
                product.Pinyin = dataRow.ItemArray[2].ToString();
                product.SpecificationId = dataRow.ItemArray[3].ToString();
                product.SpecificationQuantity = dataRow.ItemArray[4].ToString();
                product.ManufactoryId = dataRow.ItemArray[5].ToString();
                productList.Add(product);
            }
            return productList;
        }

        public bool updateProductById(Product product)
        {
            string SQL = "update product set ";
            if (0 > product.Id.Length)
                return false;
            SQL += "name='" + product.Name + "',pinyin='" + product.Pinyin + "'," + "specification_id='" + product.SpecificationId + "',specification_quantity='" + product.SpecificationQuantity + "',manufactory_id='" + product.ManufactoryId + "' Where id='" + product.Id.Trim() + "'";

            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
