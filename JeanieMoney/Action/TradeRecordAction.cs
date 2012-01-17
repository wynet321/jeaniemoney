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
            string SQL = "select id,category_id,payer_id,location_id,payment_category_id,money,date from trade_record where id='" + id + "'";
            DataTable dataTable = Database.getDataTable(SQL);
            TradeRecord tradeRecord = new TradeRecord();
            tradeRecord.Id = id;
            tradeRecord.CategoryId = dataTable.Rows[0].ItemArray[1].ToString();
            tradeRecord.PayerId = dataTable.Rows[0].ItemArray[2].ToString();
            tradeRecord.LocationId = dataTable.Rows[0].ItemArray[3].ToString();
            tradeRecord.PaymentCategoryId = dataTable.Rows[0].ItemArray[4].ToString();
            tradeRecord.Money = dataTable.Rows[0].ItemArray[5].ToString();
            tradeRecord.Date = dataTable.Rows[0].ItemArray[6].ToString();
            return tradeRecord;
        }

        public List<TradeRecord> retrieveTradeRecordList()
        {
            string SQL = "select id,category_id,payer_id,location_id,payment_category_id,money,date from trade_record";
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
            string SQL = "select id,category_id,payer_id,location_id,payment_category_id,money,date from trade_record where pinyin like '" + pinyin + "%'";
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
                tradeRecord.Id = dataRow.ItemArray[0].ToString();
                tradeRecord.CategoryId = dataRow.ItemArray[1].ToString();
                tradeRecord.PayerId = dataRow.ItemArray[2].ToString();
                tradeRecord.LocationId = dataRow.ItemArray[3].ToString();
                tradeRecord.PaymentCategoryId = dataRow.ItemArray[4].ToString();
                tradeRecord.Money = dataRow.ItemArray[5].ToString();
                tradeRecord.Date = dataRow.ItemArray[6].ToString();
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
