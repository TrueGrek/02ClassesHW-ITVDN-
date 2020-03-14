using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        public string Goods {get;set;}
        public int quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void InvoiceShow(bool needNDS)
        {
            double cost;
            switch (Goods)
            {
                case "Mobil": cost = 5000;
                    break;
                case "Headphones":
                    cost = 1000;
                    break;
                case "mouse":
                    cost = 2000;
                    break;
                default:
                    cost = 0;
                    break;
            }
            if (needNDS)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Сумма оплаты: {0}", cost*quantity);
        }
    }
}
