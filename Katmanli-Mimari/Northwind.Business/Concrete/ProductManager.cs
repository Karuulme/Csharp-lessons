using Northwind.DataAccess.Concrete;
using Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
  public  class ProductManager
    {
        PorductDal _productDal = new PorductDal();
        public List<Product> GetAll()
        {
          
            return _productDal.GetAll();


        }

    }
}
