using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using ClassLibrary.lib;
using System.Data.Common;
using System.Data.SqlClient;
using ClassLibrary.lib.Handler;

namespace JeanieMoney.Actions
{
    class TradeRecordAndTradeRecordDetailAction
    {
        private IDbHandler dbHandler = HandlerFactory.getDbHandler();
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
        public bool createTrade(TradeRecord tradeRecord, List<TradeRecordDetail> tradeRecordDetailList)
        {
            List<SqlCommand> commandList = new List<SqlCommand>();
            List<DbParameter[]> parameterList=new List<DbParameter[]>();
            TradeRecordAction tradeRecordAction = new TradeRecordAction();
            TradeRecordDetailAction tradeRecordDetailAction = new TradeRecordDetailAction();
            SqlCommand command = new SqlCommand("insert into trade_record values(@id,@categoryid,@payerid,@locationid,@paymentmodeid,@money,@date)");
            DbParameter[] dbParameterArray = generateDbParameterArray(tradeRecord); 
            commandList.Add(command);
            parameterList.Add(dbParameterArray);
            foreach (TradeRecordDetail tradeRecordDetail in tradeRecordDetailList)
            {
                command = new SqlCommand( "insert into trade_record_detail values(@id, @trade_record_id,@product_id,@quantity,@price,@benificiary_id)");
                dbParameterArray = generateDbParameterArray(tradeRecordDetail);
                commandList.Add(command); 
                parameterList.Add(dbParameterArray);
            }
            if (HandlerFactory.getDbHandler().execTranx(commandList,parameterList)==commandList.Count)
                return true;
            return false;
        }
    }
}
