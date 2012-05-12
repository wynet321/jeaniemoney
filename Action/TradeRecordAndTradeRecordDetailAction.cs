using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entity;
using JeanieMoney.Utility;

namespace JeanieMoney.Action
{
    class TradeRecordAndTradeRecordDetailAction
    {
        public bool createTrade(TradeRecord tradeRecord, List<TradeRecordDetail> tradeRecordDetailList)
        {
            List<string> commandList = new List<string>();
            TradeRecordAction tradeRecordAction = new TradeRecordAction();
            TradeRecordDetailAction tradeRecordDetailAction = new TradeRecordDetailAction();
            commandList.Add(tradeRecordAction.createTradeRecordCommand(tradeRecord));
            foreach (TradeRecordDetail tradeRecordDetail in tradeRecordDetailList)
            {
                commandList.Add(tradeRecordDetailAction.createTradeRecordDetailCommand(tradeRecordDetail)); 
            }
            if (DbHandler.execTranx(commandList)==commandList.Count)
                return true;
            return false;
        }
    }
}
