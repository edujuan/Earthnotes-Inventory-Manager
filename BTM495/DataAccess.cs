using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTM495
{
    class DataAccess
    {
        public DataTable GetProducts()
        {
            DataTable dtProducts2 = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
            //connection string


            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtProducts2.Load(reader);
                }
            }

            return dtProducts2;
        }


        public void AddProducts(int orderQuantity, int productID)
        {

            string sql = "UPDATE Products SET Quantity=Quantity+@OrderQuantity WHERE ProductID = @ProductID;";


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var affectedRows = connection.Execute(sql, new { OrderQuantity = orderQuantity, ProductID = productID });

                Console.WriteLine(affectedRows);
            }
        }


        public void AddOrder(int orderQuantity, int productID)
        {

            string sql = "UPDATE Products SET Quantity=Quantity-@OrderQuantity WHERE ProductID = @ProductID;";


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var affectedRows = connection.Execute(sql, new { OrderQuantity = orderQuantity, ProductID = productID });

                Console.WriteLine(affectedRows);
            }
        }



        public DataTable GetMissingProducts()
        {
            DataTable dtProducts2 = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
            //connection string


            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE QUANTITY = 0", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtProducts2.Load(reader);
                }
            }

            return dtProducts2;
        }


    }
}
