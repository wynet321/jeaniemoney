using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using System.Data;
using ClassLibrary.lib;
using ClassLibrary.lib.Handler;
using System.Data.Common;

namespace JeanieMoney.Actions
{
    class PaymentModeAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(PaymentMode paymentMode)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",paymentMode.Id,paymentMode.Id.GetType().Name),
                    dbHandler.generateDbParameter("@name", paymentMode.Name, paymentMode.Name.GetType().Name),
                    dbHandler.generateDbParameter("@abbr", paymentMode.Abbr, paymentMode.Abbr.GetType().Name),
                    };
            return dbParameterArray;
        }

        public bool create(PaymentMode paymentMode)
        {
            string command = "insert into payment_mode values(@id,@name,@abbr)";
            DbParameter[] dbParameterArray = generateDbParameterArray(paymentMode);
            if (1 == HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public PaymentMode retrieve(PaymentMode paymentMode)
        {
            string command = "select * from payment_mode where id=@id";
            if (string.IsNullOrWhiteSpace(paymentMode.Id))
                return paymentMode;
            DbParameter[] dbParameterArray = generateDbParameterArray(paymentMode);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            paymentMode = new PaymentMode();
            paymentMode.Id = dataTable.Rows[0]["id"].ToString();
            paymentMode.Name = dataTable.Rows[0]["name"].ToString();
            paymentMode.Abbr = dataTable.Rows[0]["abbr"].ToString();
            return paymentMode;
        }

        //public List<PaymentMode> retrievePaymentModeList()
        //{
        //    string command = "select * from payment_mode";
        //    List<PaymentMode> paymentModeList = retrievePaymentModeListByCommand(command);
        //    return paymentModeList;
        //}

        public bool delete(PaymentMode paymentMode)
        {
            string command = "delete from payment_mode where id=@id";
            if (string.IsNullOrWhiteSpace(paymentMode.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(paymentMode);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<PaymentMode> retrievePaymentModeListByAbbr(string abbr)
        //{
        //    string command = "select * from payment_mode where abbr like '" + abbr + "%'";
        //    List<PaymentMode> paymentModeList = retrievePaymentModeListByCommand(command);
        //    return paymentModeList;
        //}

        public List<PaymentMode> retrieveList(PaymentMode paymentMode)
        {
            string command = "select * from payment_mode";
            if (!string.IsNullOrWhiteSpace(paymentMode.Abbr))
                command += " where abbr like @abbr";
            DbParameter[] dbParameterArray = generateDbParameterArray(paymentMode);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<PaymentMode> paymentModeList = new List<PaymentMode>();
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
            string command = "update payment_mode set name=@name,abbr=@abbr Where id=@id";
            if (string.IsNullOrWhiteSpace(paymentMode.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(paymentMode);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }
}
