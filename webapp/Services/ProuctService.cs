using System;
using System.Data.SqlClient;
using webapp.Models;

//create a productService that will poplulate the list
namespace webapp.Services
{
    public class ProuctService
    {
        private static string db_source = "appserver3000030";
        private static string db_user = "sqlAdmin";
        private static string db_password = "Azure123";
        private static string db_database = "appdb";




        private SqlConnection GetConnection()
        {
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }

        public List<Product> GetProducts()
        {
            SqlConnection conn = GetConnection();
            List<Product> _product_list = new List<Product>();
            string statement = "Select ProductId, ProductName, Quantigy from Products";
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(statement, conn);

           // using (SqlDataReader reader = cmd.ExecuteReader())
           // {
            //    while (reader.Read())

            for (var i=1; i <=4; i++)
                {
                Product product = new Product()
                {
                    ProductID = i,
                    ProductName = String.Concat("Product-", i),
                      Quantity = i*10,
                 };
                    _product_list.Add(product);

                }
            //}
            //conn.Close();
            return _product_list;

        }
    }
}

