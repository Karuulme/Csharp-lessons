using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonManeger manager = new PersonManeger();
            Student student = new Student
            {
                Id = 1,
                FirstName = "Muhammet",
                LastName = "Karul",
                Departman = "Sofware Engineer Student"
            };


            manager.add(student);



            CostomerManager costomerManager = new CostomerManager();
            costomerManager.Add(new SqlServerCostomerDal()); ;


            ICostumerDal[] costumerDal = new ICostumerDal[3]
            {
                new SqlServerCostomerDal(),
                new OracleCostomerDal(),
              new MysqlCostomerDal()


            };

            foreach (var a in costumerDal)
            {
                a.Add();


            }


        }


        interface IPerson
        {
            int Id { get; set; }
            String FirstName { get; set; }
            String LastName { get; set; }
        }

        class Costomer:IPerson
        {
           public int Id { get; set; }
           public String FirstName { get; set; }
           public  String LastName { get; set; }
            public String Address { get; set; }

        }
        class  Student:IPerson
        {

            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Departman { get; set; }

        }
        class PersonManeger
        {
            public void add(IPerson person)
            {

                Console.WriteLine(person.FirstName);

            }


        }

    }
}
