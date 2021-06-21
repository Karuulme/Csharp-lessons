using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);


            EmployerManager employerManager = new EmployerManager(new FİleLogger());


            employerManager.Add();

            PersonManager personManager = new PersonManager("product");
            personManager.Add();

        }
    }
    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;


        }
        public CustomerManager()
        {



        }

        public void List()
        {

            Console.WriteLine("Listed! {0}", _count);


        }
        public void Add()
        {

            Console.WriteLine("Added!");

        }


    }
    class Product
    {
        public Product()
        {



        }
        private int _Id;
        private string _Name;

        public Product(int Id, string Name)
        {

            _Id = Id;
            _Name = Name;

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();

    }
    class DatebaseLogger : ILogger
    {

        public void Log()
        {
            Console.WriteLine("Database Logged");

        }


    }
    class FİleLogger : ILogger
    {

        public void Log()
        {

            Console.WriteLine("File Logged");

        }


    }
    class EmployerManager
    {

        public ILogger _logger;
        public EmployerManager(ILogger logger)
        {
            _logger = logger;

        }

        public void Add()
        {

            _logger.Log();
            Console.WriteLine("Edded!");

        }


    }
}


