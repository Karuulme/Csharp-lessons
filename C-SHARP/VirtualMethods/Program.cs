using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            Mysql mysql = new Mysql();
            mysql.Add();
            Console.ReadLine();
        }
    }
    class Datebase
    {
        public virtual void Add()
        { 

            Console.WriteLine("Added");

        }
        public virtual void Delete()
        {

            Console.WriteLine("Delete");



        }


    }
    class SqlServer : Datebase
    {
        public override void Add()
        {
            Console.WriteLine("Added Sql Server");
            //base.Add();
        }


    }
    class Mysql : Datebase
    {



    }
}
