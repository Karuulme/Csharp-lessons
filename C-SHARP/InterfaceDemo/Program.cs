using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWork[] work = new IWork[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };
            foreach (var workk in work )
            {

                workk.Work();

            }

        }



    }
    interface IWork
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

    class Manager : IWork, IEat, ISalary
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
    class Worker: IWork, IEat, ISalary
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

    class Robot : IWork
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

}
