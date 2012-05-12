using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class TradeRecord
    {
        private string id = String.Empty;
        public string Id { get { return id; } set { id = value; } }

        private string categoryid = String.Empty;
        public string CategoryId { get { return categoryid; } set { categoryid = value; } }

        private string payerid = String.Empty;
        public string PayerId { get { return payerid; } set { payerid = value; } }

        private string locationid = String.Empty;
        public string LocationId { get { return locationid; } set { locationid = value; } }

        private string paymentcategoryid = String.Empty;
        public string PaymentModeId { get { return paymentcategoryid; } set { paymentcategoryid = value; } }

        private string money = String.Empty;
        public string Money { get { return money; } set { money = value; } }

        private string date = String.Empty;
        public string Date { get { return date; } set { date = value; } }

    }
}
