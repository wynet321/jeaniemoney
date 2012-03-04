using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class PaymentModeAction
    {
        public bool createPaymentMode(PaymentMode paymentMode)
        {
            string command = "insert into payment_mode values('" + paymentMode.Id + "','" + paymentMode.Name + "','" + paymentMode.Abbr + "')";
            if (1 == JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }

        public PaymentMode retrievePaymentModeById(string id)
        {
            string command = "select * from payment_mode where id='" + id + "'";
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            PaymentMode paymentMode = new PaymentMode();
            paymentMode.Id = id;
            paymentMode.Name = dataTable.Rows[0]["name"].ToString();
            paymentMode.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return paymentMode;
        }

        public List<PaymentMode> retrievePaymentModeList()
        {
            string command = "select * from payment_mode";
            List<PaymentMode> paymentModeList = retrievePaymentModeListByCommand(command);
            return paymentModeList;
        }

        public bool deletePaymentModeById(string id)
        {
            string command = "delete from payment_mode where id='" + id + "'";
            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
        public List<PaymentMode> retrievePaymentModeListByAbbr(string abbr)
        {
            string command = "select * from payment_mode where abbr like '" + abbr + "%'";
            List<PaymentMode> paymentModeList = retrievePaymentModeListByCommand(command);
            return paymentModeList;
        }

        public List<PaymentMode> retrievePaymentModeListByCommand(string command)
        {
            DataTable dataTable = JeanieMoneyDBHelper.getDataTable(command);
            List<PaymentMode> paymentModeList = new List<PaymentMode>();
            PaymentMode paymentMode;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                paymentMode = new PaymentMode();
                paymentMode.Id = dataRow["id"].ToString();
                paymentMode.Name = dataRow["name"].ToString();
                paymentMode.Abbr = dataRow["abbr"].ToString();
                paymentModeList.Add(paymentMode);
            }
            return paymentModeList;
        }

        public bool updatePaymentModeById(PaymentMode paymentMode)
        {
            string command = "update payment_mode set ";
            if (0 > paymentMode.Id.Length)
                return false;
            command += "name='" + paymentMode.Name + "',abbr='" + paymentMode.Abbr + "' Where id='" + paymentMode.Id.Trim() + "'";

            if (0 < JeanieMoneyDBHelper.execCommand(command))
                return true;
            return false;
        }
    }
}
