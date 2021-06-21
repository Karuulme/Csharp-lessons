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
        }
    }
    class Database
    {
        public virtual void Add()
        {

            Console.WriteLine("Eklendi");

        }
        public virtual void Delete()
        {

            Console.WriteLine("Silindi");
        }


    }
    class SqlServer : Database
    {

        public override void Add()
        {
            Console.WriteLine("Sql Server Add");
        }

    }
    class Mysql : Database
    {



    }
   
}
