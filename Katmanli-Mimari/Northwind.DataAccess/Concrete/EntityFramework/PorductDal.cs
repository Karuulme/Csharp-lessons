using Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
   public class EfPorductDal:EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {
       
       
    }
}
