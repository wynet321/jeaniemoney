using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class TradeRecordDetail
    {
        private string id="";
        public string Id { get { return id; } set { id = value; } }

        private string traderecordid = "";
        public string TradeRecordId { get { return traderecordid; } set { traderecordid = value; } }

        private string productid = "";
        public string ProductId { get { return productid; } set { productid = value; } }

        private string quantity = "";
        public string Quantity { get { return quantity; } set { quantity = value; } }

        private string price = "";
        public string Price { get { return price; } set { price = value; } }

        private string beneficiaryid = "";
        public string BeneficiaryId { get { return beneficiaryid; } set { beneficiaryid = value; } }
    }
}
