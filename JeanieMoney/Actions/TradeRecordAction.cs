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
    class TradeRecordAction : IAction<TradeRecord>
    {
        private DbHandler dbHandler = HandlerFactory.getDbHandler();
        private DbParameter[] generateDbParameterArray(TradeRecord tradeRecord)
        {
            DbParameter[] dbParameterArray ={
                    dbHandler.generateDbParameter("@id",tradeRecord.Id,tradeRecord.Id.GetType().Name),
                    dbHandler.generateDbParameter("@categoryid", tradeRecord.CategoryId, tradeRecord.CategoryId.GetType().Name),
                    dbHandler.generateDbParameter("@payerid", tradeRecord.PayerId, tradeRecord.PayerId.GetType().Name),
                    dbHandler.generateDbParameter("@locationid", tradeRecord.LocationId, tradeRecord.LocationId.GetType().Name),
                    dbHandler.generateDbParameter("@paymentmodeid", tradeRecord.PaymentModeId, tradeRecord.PaymentModeId.GetType().Name),
                    dbHandler.generateDbParameter("@money", tradeRecord.Money, tradeRecord.Money.GetType().Name),
                    dbHandler.generateDbParameter("@date", tradeRecord.Date, tradeRecord.Date.GetType().Name)
                    };
            return dbParameterArray;
        }
        public bool create(TradeRecord tradeRecord)
        {
            string command = "insert into trade_record values(@id,@categoryid,@payerid,@locationid,@paymentmodeid,@money,@date)";
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecord); 
            if (HandlerFactory.getDbHandler().execCommand(command,dbParameterArray)==1)
                return true;
            return false;
        }

        public TradeRecord retrieve(TradeRecord tradeRecord)
        {
            string command = "select * from trade_record where id=@id";
            if (string.IsNullOrWhiteSpace(tradeRecord.Id))
                return tradeRecord;
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecord); 
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            tradeRecord = new TradeRecord();
            tradeRecord.Id = dataTable.Rows[0]["id"].ToString();
            tradeRecord.CategoryId = dataTable.Rows[0]["category_id"].ToString();
            tradeRecord.PayerId = dataTable.Rows[0]["payer_id"].ToString();
            tradeRecord.LocationId = dataTable.Rows[0]["location_id"].ToString();
            tradeRecord.PaymentModeId = dataTable.Rows[0]["payment_mode_id"].ToString();
            tradeRecord.Money = dataTable.Rows[0]["money"].ToString();
            tradeRecord.Date = dataTable.Rows[0]["date"].ToString();
            return tradeRecord;
        }

        //public List<TradeRecord> retrieveTradeRecordList()
        //{
        //    string command = "select * from trade_record";
        //    List<TradeRecord> tradeRecordList = retrieveTradeRecordListBySQL(command);
        //    return tradeRecordList;
        //}

        public bool delete(TradeRecord tradeRecord)
        {
            string command = "delete from tradeRecord where id=@id";
            if (string.IsNullOrWhiteSpace(tradeRecord.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecord); 
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
        //public List<TradeRecord> retrieveTradeRecordListByAbbr(string abbr)
        //{
        //    string command = "select * from trade_record where abbr like '" + abbr + "%'";
        //    List<TradeRecord> tradeRecordList = retrieveTradeRecordListBySQL(command);
        //    return tradeRecordList;
        //}

        public List<TradeRecord> retrieveList(TradeRecord tradeRecord)
        {
            string command = "select * from trade_record";
            if (string.IsNullOrWhiteSpace(tradeRecord.Id))
                command += " where abbr like @abbr%";
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecord); 
            DataTable dataTable = HandlerFactory.getDbHandler().getDataTable(command,dbParameterArray);
            List<TradeRecord> tradeRecordList = new List<TradeRecord>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tradeRecord = new TradeRecord();
                tradeRecord.Id = dataRow[0].ToString();
                tradeRecord.CategoryId = dataRow["category_id"].ToString();
                tradeRecord.PayerId = dataRow["parent_id"].ToString();
                tradeRecord.LocationId = dataRow["location_id"].ToString();
                tradeRecord.PaymentModeId = dataRow["payment_mode_id"].ToString();
                tradeRecord.Money = dataRow["money"].ToString();
                tradeRecord.Date = dataRow["date"].ToString();
                tradeRecordList.Add(tradeRecord);
            }
            return tradeRecordList;
        }

        public bool update(TradeRecord tradeRecord)
        {
            string command = "update trade_record set category_id=@categoryid,payer_id=@payerid,location_id=@locationid,payment_mode_id=@paymentmodeid,money=@money,date=@date Where id=@id";
            if (string.IsNullOrWhiteSpace(tradeRecord.Id))
                return false;
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecord); 
            if (0 < HandlerFactory.getDbHandler().execCommand(command,dbParameterArray))
                return true;
            return false;
        }
    }
}
