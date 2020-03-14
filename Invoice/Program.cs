using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(123456, "Vlad", "ITVDN") { Goods = "Mobil", quantity = 2 };

            inv.InvoiceShow(true);
            inv.InvoiceShow(false);
            Console.ReadKey();
        }
    }
}
