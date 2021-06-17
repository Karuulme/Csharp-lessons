using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {



            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();











        }
       class CustomerManager
        {
            public void Add()
            {
                Logger logger = new Logger();
                logger.Log();
                Console.WriteLine("Customer Added!");


            }



        }
        class Logger
        {
            public void Log()
            {
                Console.WriteLine("Logged TO database");


            }


        }
    }
}
