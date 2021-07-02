using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
   public  class ProductDal
    {
        public List<Product> GetAll()
        {
            using (EtradeContext context = new EtradeContext())
            {
               return  context.Product.ToList();

            }


        }
        public List<Product> GetByName(string key)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Product.Where(p=>p.Name.Contains(key)).ToList();

            }


        }


        public List<Product> GetByUnitPrice(decimal price) 
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Product.Where(p => p.UnitPrice>=price).ToList();

            }


        }

        public Product GetById(int Id)
        {
            using (EtradeContext context = new EtradeContext())
            {

              //  return context.Product.FirstOrDefault(p=> p.Id==Id); birden fazla alır
                return context.Product.SingleOrDefault(p => p.Id == Id); // tek bir tane alır, birden fazla varsa hata verir



            }


        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Product.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();

            }


        }


        public void Add(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                 context.Product.Add(product);
                context.SaveChanges();

            }

        }
        public void Update(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }

        }
        public void Delete(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }

    }
}
