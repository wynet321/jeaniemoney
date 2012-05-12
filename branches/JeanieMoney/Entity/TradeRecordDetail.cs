using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class TradeRecordDetail
    {
        private string id=String.Empty;
        public string Id { get { return id; } set { id = value; } }

        private string traderecordid = String.Empty;
        public string TradeRecordId { get { return traderecordid; } set { traderecordid = value; } }

        private string productid = String.Empty;
        public string ProductId { get { return productid; } set { productid = value; } }

        private string quantity = String.Empty;
        public string Quantity { get { return quantity; } set { quantity = value; } }

        private string price = String.Empty;
        public string Price { get { return price; } set { price = value; } }

        private string beneficiaryid = String.Empty;
        public string BeneficiaryId { get { return beneficiaryid; } set { beneficiaryid = value; } }
    }
}
