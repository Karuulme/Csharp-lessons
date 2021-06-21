using System;

namespace RecepDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();
            customerManager.Add();

        }
    }
    class CustomerManager
    {
        public ILogger logger { get; set; }

        public void Add()
        {
          
            logger.Log();
            Console.WriteLine("Customer Add");


        }


    }
    class DatabaseLogger: ILogger
    {
        public void Log()
        {

            Console.WriteLine("Database Logged!");

        }
        public void Log2()
        {

            Console.WriteLine("Database Logged!");

        }



    }
    class FilebaseLogger : ILogger
    {
        public void Log()
        {

            Console.WriteLine("File Logged!");

        }
        public void Log2()
        {

            Console.WriteLine("File Logged!!");

        }



    }
    interface ILogger
    {

         void Log();
        void Log2();

    }



}
