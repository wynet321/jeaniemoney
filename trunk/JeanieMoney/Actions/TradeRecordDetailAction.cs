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
    class TradeRecordDetailAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(TradeRecordDetail tradeRecordDetail)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",tradeRecordDetail.Id,tradeRecordDetail.Id.GetType().Name),
                    dbHandler.generateDbParameter("@benificiary_id", tradeRecordDetail.BeneficiaryId, tradeRecordDetail.BeneficiaryId.GetType().Name),
                    dbHandler.generateDbParameter("@product_id", tradeRecordDetail.ProductId, tradeRecordDetail.ProductId.GetType().Name),
                    dbHandler.generateDbParameter("@price", tradeRecordDetail.Price, tradeRecordDetail.Price.GetType().Name),
                    dbHandler.generateDbParameter("@quantity", tradeRecordDetail.Quantity, tradeRecordDetail.Quantity.GetType().Name),
                    dbHandler.generateDbParameter("@trade_record_id", tradeRecordDetail.TradeRecordId, tradeRecordDetail.TradeRecordId.GetType().Name)
            };
            return dbParameterArray;
        }

        public bool createTradeRecordDetail(TradeRecordDetail tradeRecordDetail)
        {
            string command = "insert into trade_record_detail values(@id, @trade_record_id,@product_id,@quantity,@price,@benificiary_id)";
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
            int executionResult = dbHandler.execCommand(command, dbParameterArray);
            return (executionResult > 0) ? true : false;
        }

        public TradeRecordDetail retrieveTradeRecordDetailById(TradeRecordDetail tradeRecordDetail)
        {
            string command = "select * from trade_record_detail where id=@id";
            if (string.IsNullOrWhiteSpace(tradeRecordDetail.Id))
                return new TradeRecordDetail();
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            tradeRecordDetail = new TradeRecordDetail();
            tradeRecordDetail.Id = dataTable.Rows[0]["id"].ToString();
            tradeRecordDetail.TradeRecordId = dataTable.Rows[0]["trade_record_id"].ToString();
            tradeRecordDetail.ProductId = dataTable.Rows[0]["product_id"].ToString();
            tradeRecordDetail.Quantity = dataTable.Rows[0]["quantity"].ToString();
            tradeRecordDetail.Price = dataTable.Rows[0]["price"].ToString();
            tradeRecordDetail.BeneficiaryId = dataTable.Rows[0]["beneficiary_id"].ToString();
            return tradeRecordDetail;
        }

        public List<TradeRecordDetail> retrieveList()
        {
            string command = "select * from trade_record_detail";
            TradeRecordDetail tradeRecordDetail = new TradeRecordDetail();
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<TradeRecordDetail> tradeRecordDetailList = new List<TradeRecordDetail>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tradeRecordDetail = new TradeRecordDetail();
                tradeRecordDetail.Id = dataRow[0].ToString();
                tradeRecordDetail.TradeRecordId = dataRow["trade_record_id"].ToString();
                tradeRecordDetail.ProductId = dataRow["product_id"].ToString();
                tradeRecordDetail.Quantity = dataRow["quantity"].ToString();
                tradeRecordDetail.Price = dataRow["price"].ToString();
                tradeRecordDetail.BeneficiaryId = dataRow["beneficiary_id"].ToString();
                tradeRecordDetailList.Add(tradeRecordDetail);
            }
            return tradeRecordDetailList;
        }

        public bool delete(TradeRecordDetail tradeRecordDetail)
        {
            string command = "delete from tradeRecordDetail where id=@id";
            if (string.IsNullOrWhiteSpace(tradeRecordDetail.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
            if (0 < HandlerFactory.getDbHandler().execCommand(command, dbParameterArray))
                return true;
            return false;
        }
        //public List<TradeRecordDetail> retrieveTradeRecordDetailListByAbbr(string abbr)
        //{
        //    string command = "select * from trade_record_detail where abbr like '" + abbr + "%'";
        //    TradeRecordDetail tradeRecordDetail = new TradeRecordDetail();
        //    tradeRecordDetail.abb = id;
        //    DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
        //    List<TradeRecordDetail> tradeRecordDetailList = retrieveTradeRecordDetailListBySQL(command);
        //    return tradeRecordDetailList;
        //}

       
        public bool update(TradeRecordDetail tradeRecordDetail)
        {
            string command = "update trade_record_detail set trade_record_id=@trade_record_id,product_id=@product_id,quantity=@quantity,price=@price,beneficiary_id=@beneficiary_id Where id=@id";
            if (string.IsNullOrWhiteSpace(tradeRecordDetail.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }

        public string getProductAveragePriceByProductId(string productId)
        {
            string command = "SELECT AVG(price) AS average_price FROM trade_record_detail WHERE product_id = @product_id";
            TradeRecordDetail tradeRecordDetail = new TradeRecordDetail();
            tradeRecordDetail.ProductId = productId;
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecordDetail);
            string result = String.Empty;
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            if (0 < dataTable.Rows.Count)
                result = dataTable.Rows[0]["average_price"].ToString();
            return result;
        }
    }
}
