using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new Oracle();
            dataBase.Delete();
            dataBase.Add();

            DataBase dataBase1 = new SqlServer();
            dataBase1.Add();
            dataBase1.Delete();

        }
    }

    abstract class DataBase
    {

        public void Add()
        {

            Console.WriteLine("Added");
        }
        public abstract void Delete();
    }
    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted sql");
        }
    }
    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted Oracle");
        }
    }
}
