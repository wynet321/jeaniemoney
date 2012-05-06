using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class TradeRecordDetailAction
    {
        public bool createTradeRecordDetail(TradeRecordDetail tradeRecordDetail)
        {
            string command = createTradeRecordDetailCommand(tradeRecordDetail);
            if (0 < DBHandler.execCommand(command))
                return true;
            return false;
        }

        public string createTradeRecordDetailCommand(TradeRecordDetail tradeRecordDetail)
        {
            string command = "insert into trade_record_detail values('" + tradeRecordDetail.Id + "','" + tradeRecordDetail.TradeRecordId + "','" + tradeRecordDetail.ProductId + "','" + tradeRecordDetail.Quantity + "','" + tradeRecordDetail.Price + "','" + tradeRecordDetail.BeneficiaryId + "')";
            return command;
        }

        public TradeRecordDetail retrieveTradeRecordDetailById(string id)
        {
            string command = "select * from trade_record_detail where id='" + id + "'";
            DataTable dataTable = DBHandler.getDataTable(command);
            TradeRecordDetail tradeRecordDetail = new TradeRecordDetail();
            tradeRecordDetail.Id = id;
            tradeRecordDetail.TradeRecordId = dataTable.Rows[0]["trade_record_id"].ToString();
            tradeRecordDetail.ProductId = dataTable.Rows[0]["product_id"].ToString();
            tradeRecordDetail.Quantity = dataTable.Rows[0]["quantity"].ToString();
            tradeRecordDetail.Price = dataTable.Rows[0]["price"].ToString();
            tradeRecordDetail.BeneficiaryId = dataTable.Rows[0]["beneficiary_id"].ToString();
            return tradeRecordDetail;
        }

        public List<TradeRecordDetail> retrieveTradeRecordDetailList()
        {
            string command = "select * from trade_record_detail";
            List<TradeRecordDetail> tradeRecordDetailList = retrieveTradeRecordDetailListBySQL(command);
            return tradeRecordDetailList;
        }

        public bool deleteTradeRecordDetailById(string id)
        {
            string command = "delete from tradeRecordDetail where id='" + id + "'";
            if (0 < DBHandler.execCommand(command))
                return true;
            return false;
        }
        public List<TradeRecordDetail> retrieveTradeRecordDetailListByAbbr(string abbr)
        {
            string command = "select * from trade_record_detail where abbr like '" + abbr + "%'";
            List<TradeRecordDetail> tradeRecordDetailList = retrieveTradeRecordDetailListBySQL(command);
            return tradeRecordDetailList;
        }

        public List<TradeRecordDetail> retrieveTradeRecordDetailListBySQL(string command)
        {
            DataTable dataTable = DBHandler.getDataTable(command);
            List<TradeRecordDetail> tradeRecordDetailList = new List<TradeRecordDetail>();
            TradeRecordDetail tradeRecordDetail;
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

        public bool updateTradeRecordDetailById(TradeRecordDetail tradeRecordDetail)
        {
            string command = "update trade_record_detail set ";
            if (0 > tradeRecordDetail.Id.Length)
                return false;
            command += "trade_record_id='" + tradeRecordDetail.TradeRecordId + "',product_id='" + tradeRecordDetail.ProductId + "',quantity='" + tradeRecordDetail.Quantity + "',price='" + tradeRecordDetail.Price + "',beneficiary_id='" + tradeRecordDetail.BeneficiaryId + "' Where id='" + tradeRecordDetail.Id.Trim() + "'";
            if (0 < DBHandler.execCommand(command))
                return true;
            return false;
        }

        public string getProductAveragePriceByProductId(string productId)
        {
            string command = "SELECT  AVG(price) AS average_price FROM trade_record_detail WHERE (product_id = '"+productId+"')";
            string result = String.Empty;
            DataTable dataTable = DBHandler.getDataTable(command);
            if (0 < dataTable.Rows.Count)
                result = dataTable.Rows[0]["average_price"].ToString();
            return result;
        }
    }
}
