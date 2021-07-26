using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.Mysql
{
    public class MysqlDatabase : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {

            List<Product> products = new List<Product>
            {

                new Product{ProductId=1,ProductName="laptop",CategoryId=1,QuantityPerUnit="1 kutu",UnitPrice=3000,UnitsInStock=55}

            };
            return products;




        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
