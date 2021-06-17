using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[1]
            {
               new Customer()
                


            };


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
        public string City { get; set; }


    }
    class Student : Person
    {
        public string Department { get; set; }


    }



}
