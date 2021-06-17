using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            EmloyeeManager emloyeeManager = new EmloyeeManager(new DatabaseLogger());
            emloyeeManager.Add();

            PersonManager personManager = new PersonManager("selam");
            personManager.Add();

            




        }
    }
    class CustomerManager
    {
        private int _count;


    public CustomerManager(int count)
        {

            _count=count;
            

        }
        public void List()
        {
            Console.WriteLine("Listed");

        }

        public void Add()
        {
            Console.WriteLine("Addeed");


        }

    }
    class Product
    {
        public Product()
        {




        }
        private int _Id;
        private string _Name;
        public Product(int Id, string name) {
            _Id = Id;
            _Name = name;
        
        }

        public int Id { get; set; }
        public string Name { get;set;}

    }
    interface ILogger
    {

        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {

            Console.WriteLine("Logger to database");

        }


    }
    class FileLogger : ILogger
    {
        public void Log()
        {

            Console.WriteLine("Logger to File");

        }


    }
    class EmloyeeManager
    {
        private ILogger _logger;
        public EmloyeeManager(ILogger logger)
        {
            _logger = logger;


        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Add");

        }

    }
    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {

            _entity = entity;

        }

        public void Message()
        {

            Console.WriteLine("{0} message",_entity);

        }


    }
     class PersonManager : BaseClass
    {

        public PersonManager(string entity):base(entity)
        {



        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
        static class Teacher
        {

            public static int Number { get; set; }


        }
        static class Utilities
        {
            public static void Validate()
            {
                Console.WriteLine  ("Vdalidation is done");


            }


        }
         class Manager
        {
            public static void DoSomething()
            {
                Console.WriteLine(" done");


            }
            public void DosDoSomething()
            {
                Console.WriteLine(" done2");


            }


        }
    }
}
