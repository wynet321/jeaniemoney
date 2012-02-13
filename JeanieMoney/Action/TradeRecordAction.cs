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
            string command = createTradeRecordCommand(tradeRecord);
            if (DBHelper.execCommand(command)==1)
                return true;
            return false;
        }

        public string createTradeRecordCommand(TradeRecord tradeRecord)
        {
            string command = "insert into trade_record values('" + tradeRecord.Id + "','" + tradeRecord.CategoryId + "','" + tradeRecord.PayerId + "','" + tradeRecord.LocationId + "','" + tradeRecord.PaymentCategoryId + "','" + tradeRecord.Money + "','" + tradeRecord.Date + "')";
            return command;
        }
        public TradeRecord retrieveTradeRecordById(string id)
        {
            string command = "select * from trade_record where id='" + id + "'";
            DataTable dataTable = DBHelper.getDataTable(command);
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
            string command = "select * from trade_record";
            List<TradeRecord> tradeRecordList = retrieveTradeRecordListBySQL(command);
            return tradeRecordList;
        }

        public bool deleteTradeRecordById(string id)
        {
            string command = "delete from tradeRecord where id='" + id + "'";
            if (0 < DBHelper.execCommand(command))
                return true;
            return false;
        }
        public List<TradeRecord> retrieveTradeRecordListByAbbr(string abbr)
        {
            string command = "select * from trade_record where abbr like '" + abbr + "%'";
            List<TradeRecord> tradeRecordList = retrieveTradeRecordListBySQL(command);
            return tradeRecordList;
        }

        public List<TradeRecord> retrieveTradeRecordListBySQL(string command)
        {
            DataTable dataTable = DBHelper.getDataTable(command);
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
            string command = "update trade_record set ";
            if (0 > tradeRecord.Id.Length)
                return false;
            command += "category_id='" + tradeRecord.CategoryId + "',payer_id='" + tradeRecord.PayerId + "',location_id='" + tradeRecord.LocationId + "',payment_category_id='" + tradeRecord.PaymentCategoryId + "',money='" + tradeRecord.Money + "',date='" + tradeRecord.Date + "' Where id='" + tradeRecord.Id.Trim() + "'";
            if (0 < DBHelper.execCommand(command))
                return true;
            return false;
        }
    }
}
