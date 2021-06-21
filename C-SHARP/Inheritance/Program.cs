using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3] { 
            new Customer{FirstName="Muhammet"},
            new Student{FirstName="Emir"},
            new Student{FirstName="berk"}
            };

            foreach (var i in person) {
                Console.WriteLine(i.FirstName);
            }

        }

       
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : Person
    {
        public string city { get; set; }

    }
    class Student : Person
    {
        public string Depertman { get; set; }

    }




}
