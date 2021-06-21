using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoNet
{
    
    public class ProductDal
    {

      public  List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();

            }
            SqlCommand command = new SqlCommand("Select * from Products",connection);

            SqlDataReader reader= command.ExecuteReader();
            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                     StockAmount = Convert.ToInt32(reader["StockAmount"])



                };
                products.Add(product);


            }

            reader.Close();
            connection.Close();
            return products;

        }
        /*
        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial cata   log=ETrade;integrated security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;

        }*/












    }
   
}
