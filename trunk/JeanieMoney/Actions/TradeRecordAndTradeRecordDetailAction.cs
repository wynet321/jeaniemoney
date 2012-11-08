using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeanieMoney.Entities;
using ClassLibrary.lib;

namespace JeanieMoney.Actions
{
    class TradeRecordAndTradeRecordDetailAction
    {
        public bool createTrade(TradeRecord tradeRecord, List<Beneficiary> tradeRecordDetailList)
        {
            List<string> commandList = new List<string>();
            TradeRecordAction tradeRecordAction = new TradeRecordAction();
            TradeRecordDetailAction tradeRecordDetailAction = new TradeRecordDetailAction();
            commandList.Add(tradeRecordAction.createTradeRecordCommand(tradeRecord));
            foreach (Beneficiary tradeRecordDetail in tradeRecordDetailList)
            {
                commandList.Add(tradeRecordDetailAction.createTradeRecordDetailCommand(tradeRecordDetail)); 
            }
            if (HandlerFactory.getDbHandler().execTranx(commandList)==commandList.Count)
                return true;
            return false;
        }
    }
}
