using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class PaymentCategoryAction
    {
        public bool createPaymentCategory(PaymentCategory paymentCategory)
        {
            string command = "insert into payment_category values('" + paymentCategory.Id + "','" + paymentCategory.Name + "','" + paymentCategory.Abbr + "')";
            if (1 == JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }

        public PaymentCategory retrievePaymentCategoryById(string id)
        {
            string command = "select * from payment_category where id='" + id + "'";
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            PaymentCategory paymentCategory = new PaymentCategory();
            paymentCategory.Id = id;
            paymentCategory.Name = dataTable.Rows[0]["name"].ToString();
            paymentCategory.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return paymentCategory;
        }

        public List<PaymentCategory> retrievePaymentCategoryList()
        {
            string command = "select * from payment_category";
            List<PaymentCategory> paymentCategoryList = retrievePaymentCategoryListByCommand(command);
            return paymentCategoryList;
        }

        public bool deletePaymentCategoryById(string id)
        {
            string command = "delete from payment_category where id='" + id + "'";
            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
        public List<PaymentCategory> retrievePaymentCategoryListByAbbr(string abbr)
        {
            string command = "select * from payment_category where abbr like '" + abbr + "%'";
            List<PaymentCategory> paymentCategoryList = retrievePaymentCategoryListByCommand(command);
            return paymentCategoryList;
        }

        public List<PaymentCategory> retrievePaymentCategoryListByCommand(string command)
        {
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            List<PaymentCategory> paymentCategoryList = new List<PaymentCategory>();
            PaymentCategory paymentCategory;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                paymentCategory = new PaymentCategory();
                paymentCategory.Id = dataRow["id"].ToString();
                paymentCategory.Name = dataRow["name"].ToString();
                paymentCategory.Abbr = dataRow["abbr"].ToString();
                paymentCategoryList.Add(paymentCategory);
            }
            return paymentCategoryList;
        }

        public bool updatePaymentCategoryById(PaymentCategory paymentCategory)
        {
            string command = "update payment_category set ";
            if (0 > paymentCategory.Id.Length)
                return false;
            command += "name='" + paymentCategory.Name + "',abbr='" + paymentCategory.Abbr + "' Where id='" + paymentCategory.Id.Trim() + "'";

            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
    }
}
