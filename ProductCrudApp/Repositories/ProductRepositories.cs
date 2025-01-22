using Microsoft.Data.SqlClient;
using ProductCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudApp.Repositories
{
    public class ProductRepositories
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDB;Integrated Security=True;Trust Server Certificate=True";

        public List<Product> GetProducts() 
        {
            var products = new List<Product>();

            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    //Fetches everything from the database. I mean, everything.
                    string sql = "SELECT * FROM ProductTable ORDER BY ProductId DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            //Makes the data show up on the crud.
                            while (reader.Read()) 
                            {
                                Product product = new Product();
                                product.productId = reader.GetInt32(0);
                                product.productName = reader.GetString(1);
                                product.quantityInStock = reader.GetInt32(2);
                                product.price = reader.GetInt32(3);

                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return products;
        }

        public Product? GetProduct(int productId) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    //Fetches the product by its ID.
                    connection.Open();
                    string sql = "SELECT * FROM ProductTable WHERE ProductId=@productId";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        command.Parameters.AddWithValue("@productId", productId);
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            //Reads the data acquired from the sql command before passing it into the crud.
                            if (reader.Read()) 
                            {
                                Product product = new Product();
                                product.productId = reader.GetInt32(0);
                                product.productName = reader.GetString(1);
                                product.quantityInStock = reader.GetInt32(2);
                                product.price = reader.GetInt32(3);

                                return product;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString() );
            }

            return null;
        }

        public void CreateProduct(Product product) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    //SQL Insert Command.
                    connection.Open();
                    string sql = "INSERT INTO ProductTable " + 
                                 "(Name, QuantityInStock, Price) VALUES " + 
                                 "(@productName, @quantityInStock, @price);";

                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        //Replaces the identifiers with data from product so what the user writes will get appended into the database.
                        command.Parameters.AddWithValue("@productName", product.productName);
                        command.Parameters.AddWithValue("@quantityInStock", product.quantityInStock);
                        command.Parameters.AddWithValue("@price", product.price);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void UpdateProduct(Product product) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    //Updates a product, everything can be edited except the ID.
                    connection.Open();
                    string sql = "UPDATE ProductTable " + 
                                 "SET Name=@productName, QuantityInStock=@quantityInStock, Price=@price " + 
                                 "WHERE ProductId=@productId";

                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        command.Parameters.AddWithValue("@productName", product.productName);
                        command.Parameters.AddWithValue("@quantityInStock", product.quantityInStock);
                        command.Parameters.AddWithValue("@price", product.price);
                        command.Parameters.AddWithValue("@productId", product.productId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void DeleteProduct(int id) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    //Deletes a product if the input ID matches anything in the datagrid.
                    connection.Open();

                    string sql = "DELETE FROM ProductTable WHERE ProductId=@productId";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        command.Parameters.AddWithValue("@productId", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public int GetTotalValue() 
        {
            int totalvals = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    string sql = "SELECT SUM(QuantityInStock*Price) AS total FROM ProductTable;";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            while (reader.Read()) 
                            {
                                TotalValue totalvalue = new TotalValue();
                                totalvalue.totalval = reader.GetInt32(0);
                                totalvals = totalvalue.totalval;

                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return totalvals;
        }
    }
}
