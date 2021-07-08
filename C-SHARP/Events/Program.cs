using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {



            Product harddisk = new Product(40);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(40);
            gsm.ProductName = "Samsung";
            gsm.StockControlEvent += Gsm_StockControlEvent;
            for (int i =0;i<10;i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();


            }
         


        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("gsm about to finash!");
        }
    }
}
