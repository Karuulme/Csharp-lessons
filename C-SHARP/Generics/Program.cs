using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<string> resualt = utilities.resualt<string>("ankara","istanbul","rize");


            foreach (var i in resualt)
            {

                Console.WriteLine(i);

            }


            List<Customer> resualt2 = utilities.resualt<Customer>(new Customer() { FirstName = "memet" }, new Customer() { FirstName = "karul" });

            foreach (var i in resualt2)
            {

                Console.WriteLine(i.FirstName);

            }



        }
    }
    class Utilities
    {

     public   List<T> resualt<T>(params T[] items)
        {

            return new List<T>(items);

        }


    }




    interface IProductDal : IRepository<Product>
    {



    }
    class Customer
    {
        public string FirstName { get; set; }


    }
    class Product
    {



    }

    interface ICustomerDal: IRepository<Customer>
    {
        






    }
    interface IEntity
    {


    }
    

    class Student: IEntity
    {


    }

    interface IRepository<T> where T: class ,IEntity, new()    // sadece claslar  kullanılabilir
    {

        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);


    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }




}
