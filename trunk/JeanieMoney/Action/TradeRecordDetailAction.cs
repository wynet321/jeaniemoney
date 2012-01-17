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
            string SQL = "insert into trade_record_detail values('" + tradeRecordDetail.Id + "','" + tradeRecordDetail.AccountId + "','" + tradeRecordDetail.ProductId + "','" + tradeRecordDetail.Quantity + "','" + tradeRecordDetail.Price + "','" + tradeRecordDetail.BeneficiaryId + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public TradeRecordDetail retrieveTradeRecordDetailById(string id)
        {
            string SQL = "select id,account_id,product_id,quantity,price,beneficiary_id from trade_record_detail where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            TradeRecordDetail tradeRecordDetail = new TradeRecordDetail();
            tradeRecordDetail.Id = id;
            tradeRecordDetail.AccountId = dataTable.Rows[0].ItemArray[1].ToString();
            tradeRecordDetail.ProductId = dataTable.Rows[0].ItemArray[2].ToString();
            tradeRecordDetail.Quantity = dataTable.Rows[0].ItemArray[3].ToString();
            tradeRecordDetail.Price = dataTable.Rows[0].ItemArray[4].ToString();
            tradeRecordDetail.BeneficiaryId = dataTable.Rows[0].ItemArray[5].ToString();
            return tradeRecordDetail;
        }

        public List<TradeRecordDetail> retrieveTradeRecordDetailList()
        {
            string SQL = "select id,account_id,product_id,quantity,price,beneficiary_id from trade_record_detail";
            List<TradeRecordDetail> tradeRecordDetailList = retrieveTradeRecordDetailListBySQL(SQL);
            return tradeRecordDetailList;
        }

        public bool deleteTradeRecordDetailById(string id)
        {
            string SQL = "delete from tradeRecordDetail where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<TradeRecordDetail> retrieveTradeRecordDetailListByPinyin(string pinyin)
        {
            string SQL = "select id,account_id,product_id,quantity,price,beneficiary_id from trade_record_detail where pinyin like '" + pinyin + "%'";
            List<TradeRecordDetail> tradeRecordDetailList = retrieveTradeRecordDetailListBySQL(SQL);
            return tradeRecordDetailList;
        }

        public List<TradeRecordDetail> retrieveTradeRecordDetailListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<TradeRecordDetail> tradeRecordDetailList = new List<TradeRecordDetail>();
            TradeRecordDetail tradeRecordDetail;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tradeRecordDetail = new TradeRecordDetail();
                tradeRecordDetail.Id = dataRow.ItemArray[0].ToString();
                tradeRecordDetail.AccountId = dataRow.ItemArray[1].ToString();
                tradeRecordDetail.ProductId = dataRow.ItemArray[2].ToString();
                tradeRecordDetail.Quantity = dataRow.ItemArray[3].ToString();
                tradeRecordDetail.Price = dataRow.ItemArray[4].ToString();
                tradeRecordDetail.BeneficiaryId = dataRow.ItemArray[5].ToString();
                tradeRecordDetailList.Add(tradeRecordDetail);
            }
            return tradeRecordDetailList;
        }

        public bool updateTradeRecordDetailById(TradeRecordDetail tradeRecordDetail)
        {
            string SQL = "update trade_record_detail set ";
            if (0 > tradeRecordDetail.Id.Length)
                return false;
            SQL += "account_id='" + tradeRecordDetail.AccountId + "',product_id='" + tradeRecordDetail.ProductId + "',quantity='" + tradeRecordDetail.Quantity + "',price='" + tradeRecordDetail.Price + "',beneficiary_id='" + tradeRecordDetail.BeneficiaryId + "' Where id='" + tradeRecordDetail.Id.Trim() + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

    }
}
