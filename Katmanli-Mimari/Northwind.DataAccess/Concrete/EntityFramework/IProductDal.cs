using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entitys.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
  public  interface IProductDal:IEntityRepository<Product>
    {

      

    }
}
