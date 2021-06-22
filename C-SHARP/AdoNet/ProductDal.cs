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

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        public  List<Product> GetAll()
        {

            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();

            }
            SqlCommand command = new SqlCommand("Select * from Products",_connection);

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
            _connection.Close();
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






        public void Add(Product product)
        {

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
            SqlCommand commed = new SqlCommand(
                "INSERT INTO Products values(@name,@unitPrice,@stockAmount)",_connection);

            commed.Parameters.AddWithValue("@name",product.Name);
            commed.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            commed.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            commed.ExecuteNonQuery();
            _connection.Close();



        }
        public void Update(Product product)
        {

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
            SqlCommand commed = new SqlCommand(
                "Update  Products set Name=@name,UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@Id", _connection);

            commed.Parameters.AddWithValue("@name", product.Name);
            commed.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            commed.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            commed.Parameters.AddWithValue("@Id", product.Id);
            commed.ExecuteNonQuery();
            _connection.Close();



        }

        public void Delete(int id)
        {
           

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
            SqlCommand commed = new SqlCommand(
                "DELETE FROM Products WHERE Id=@id", _connection);

            commed.Parameters.AddWithValue("@Id",id);
            commed.ExecuteNonQuery();
            _connection.Close();



        }





    }

   
}
