using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Entity
{
    class TradeRecord
    {
        private string id = "";
        public string Id { get { return id; } set { id = value; } }

        private string categoryid = "";
        public string CategoryId { get { return categoryid; } set { categoryid = value; } }

        private string payerid = "";
        public string PayerId { get { return payerid; } set { payerid = value; } }

        private string locationid = "";
        public string LocationId { get { return locationid; } set { locationid = value; } }

        private string paymentcategoryid = "";
        public string PaymentModeId { get { return paymentcategoryid; } set { paymentcategoryid = value; } }

        private string money = "";
        public string Money { get { return money; } set { money = value; } }

        private string date = "";
        public string Date { get { return date; } set { date = value; } }

    }
}
