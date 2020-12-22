using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteF4.Models
{
    public class StoreContext
    {
        static string connectionString = @"Data Source = localhost; Initial Catalog = F4RESTAURANT; Integrated Security = True";

        /*private SqlConnection GetConnection()
        {
            return SqlConnection(connectionString);
        } */

        public List<Menu> selectMenu()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from MENU";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetDecimal(3).ToString()));
                }

            }
            return list;
        }
    }
}
