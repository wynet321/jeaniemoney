using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;
using System.Data;

namespace JeanieMoney.Action
{
    class TradeRecordAction
    {
        public bool createTradeRecord(TradeRecord tradeRecord)
        {
            string SQL = "insert into trade_record values('" + tradeRecord.Id + "','" + tradeRecord.CategoryId + "','" + tradeRecord.PayerId + "','" + tradeRecord.LocationId + "','" + tradeRecord.PaymentCategoryId + "','" + tradeRecord.Money + "','" + tradeRecord.Date + "')";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }

        public TradeRecord retrieveTradeRecordById(string id)
        {
            string SQL = "select * from trade_record where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            TradeRecord tradeRecord = new TradeRecord();
            tradeRecord.Id = id;
            tradeRecord.CategoryId = dataTable.Rows[0]["category_id"].ToString();
            tradeRecord.PayerId = dataTable.Rows[0]["payer_id"].ToString();
            tradeRecord.LocationId = dataTable.Rows[0]["location_id"].ToString();
            tradeRecord.PaymentCategoryId = dataTable.Rows[0]["payment_category_id"].ToString();
            tradeRecord.Money = dataTable.Rows[0]["money"].ToString();
            tradeRecord.Date = dataTable.Rows[0]["date"].ToString();
            return tradeRecord;
        }

        public List<TradeRecord> retrieveTradeRecordList()
        {
            string SQL = "select * from trade_record";
            List<TradeRecord> tradeRecordList = retrieveTradeRecordListBySQL(SQL);
            return tradeRecordList;
        }

        public bool deleteTradeRecordById(string id)
        {
            string SQL = "delete from tradeRecord where id='" + id + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
        public List<TradeRecord> retrieveTradeRecordListByPinyin(string pinyin)
        {
            string SQL = "select * from trade_record where pinyin like '" + pinyin + "%'";
            List<TradeRecord> tradeRecordList = retrieveTradeRecordListBySQL(SQL);
            return tradeRecordList;
        }

        public List<TradeRecord> retrieveTradeRecordListBySQL(string SQL)
        {
            DataTable dataTable = Database.getDataTable(SQL);
            List<TradeRecord> tradeRecordList = new List<TradeRecord>();
            TradeRecord tradeRecord;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tradeRecord = new TradeRecord();
                tradeRecord.Id = dataRow[0].ToString();
                tradeRecord.CategoryId = dataRow["category_id"].ToString();
                tradeRecord.PayerId = dataRow["parent_id"].ToString();
                tradeRecord.LocationId = dataRow["location_id"].ToString();
                tradeRecord.PaymentCategoryId = dataRow["payment_category_id"].ToString();
                tradeRecord.Money = dataRow["money"].ToString();
                tradeRecord.Date = dataRow["date"].ToString();
                tradeRecordList.Add(tradeRecord);
            }
            return tradeRecordList;
        }

        public bool updateTradeRecordById(TradeRecord tradeRecord)
        {
            string SQL = "update trade_record set ";
            if (0 > tradeRecord.Id.Length)
                return false;
            SQL += "category_id='" + tradeRecord.CategoryId + "',payer_id='" + tradeRecord.PayerId + "',location_id='" + tradeRecord.LocationId + "',payment_category_id='" + tradeRecord.PaymentCategoryId + "',money='" + tradeRecord.Money + "',date='" + tradeRecord.Date + "' Where id='" + tradeRecord.Id.Trim() + "'";
            if (0 < Database.execCommand(SQL))
                return true;
            return false;
        }
    }
}
