using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ArrayList citieslist =new ArrayList();
            citieslist.Add("Ankara"); // ....


            List<string> cities = new List<string>();
            cities.Add("Ankara");


            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id=0, FirstName="Muhammet"});
            customer.Add(new Customer { Id = 1, FirstName = "Emir" });
            customer.Add(new Customer { Id = 2, FirstName = "Berk" });
            foreach (var i in customer) { Console.WriteLine(i.Id+"--"+i.FirstName); }



        }
       
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

    }







}
