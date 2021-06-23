using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class EtradeContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
