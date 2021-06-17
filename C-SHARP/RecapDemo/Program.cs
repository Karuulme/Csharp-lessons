using System;

namespace RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMnager customerMnager = new CustomerMnager();
            customerMnager.Logger = new FileLOgger();
            customerMnager.Add();
        }
    }
    class CustomerMnager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {

            Logger.Log();
        

            Console.WriteLine("Customer Added!");

        }



    }
   
    class FileLOgger : ILogger
    {
        

        public void Log()
        {
            Console.WriteLine("File Logger");
        }
    }
    class DataBaseLogger : ILogger
    {
    

        public void Log()
        {
            Console.WriteLine("Data Base Logger");
        }
    }


    interface ILogger
    {
        void Log();


    }
}
