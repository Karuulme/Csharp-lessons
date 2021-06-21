using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet2
{
    class Product
    {
         SqlConnection conn = new SqlConnection(@"Data Source=FAUK; Initial Catalog=deneme; User Id=sa; password=1;");
    }
}
