using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   ArrayList cities = new ArrayList();
               cities.Add("Ankara");
               cities.Add("Adana");
               foreach (var city in cities)
               {
                   Console.WriteLine(city);
               } */
            /*
                        List<string> cities = new List<string>();
                        cities.Add("Ankara"); // sadece string ifadeler


                        List<Customer> customer = new List<Customer>();
                        customer.Add(new Customer { Id = 1, FirstName = "Memet" });
                        customer.Add(new Customer { Id = 2, FirstName = "Karul" });

                        var count = customer.Count; // eleman sayısı
                        var customer1 = new Customer
                        {
                            Id = 3, FirstName = "engin"


                        };
                        customer.Add(customer1);
                        customer.AddRange(new Customer[2]
                        {

                        new Customer{Id=4,FirstName="ali" },
                        new Customer{Id=5,FirstName="ayşe"}

                             });

                        Console.WriteLine(cities.Contains("adana"));//dizinin içinde adanaa vbar mı true-false

                       var index=  customer.IndexOf(customer1);
                        Console.WriteLine("index={0}",index);


                        foreach (var i in customer)
                        {

                            Console.WriteLine(i.FirstName);

                        }
            */

            Dictionary<string, string> distionarys = new Dictionary<string, string>();
            distionarys.Add("table", "Tablo");
            distionarys.Add("Computer","Bilgisayar");
            distionarys.Add("book","kitap");

            Console.WriteLine(distionarys["table"]);

            foreach (var item in distionarys)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

            }

            Console.WriteLine(distionarys.ContainsKey("glass")); // var olup olmadığını kontrol eder true-false

        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

        }
    }
}
