using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "memet", LastName = "karul", Age = 23 };


            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);



        }
    }
    class Customer
    {

        public int Id { get; set; }
        //[RequireProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }




    }
    class CustomerDal
    {
        public void Add(Customer CUSTOMER)
        {

            Console.WriteLine("{0},{1},{2}", CUSTOMER.FirstName, CUSTOMER.LastName, CUSTOMER.Age);

        }


    }


}
