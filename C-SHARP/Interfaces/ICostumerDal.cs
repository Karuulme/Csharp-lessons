using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICostumerDal
    {

        void Add();
        void Update();
        void Delete();

    }


    class SqlServerCostomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Dlete");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update");
        }
    }
    class OracleCostomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Uddate");
        }
    }
    class MysqlCostomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql delete");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Uddate");
        }
    }


    class CostomerManager
    {

        public void Add(ICostumerDal costumerdal)
        {
            costumerdal.Add();


        }


    }
}
