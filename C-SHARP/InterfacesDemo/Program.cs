using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]{
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach(var i in workers)
            {
                i.Work();



            }


        }
    }

   interface IWorker
    {

        void Work();
      


    }
    interface IEat
    {

        void Eat();
    }
    interface ISalary
    {

        void Salary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        
    }

}
