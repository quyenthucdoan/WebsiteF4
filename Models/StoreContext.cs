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
        //luon luon co
        static string conString = @"Data Source=localhost;Initial Catalog=F4RESTAURANT;Integrated Security=True";


        //Show MENU_Hamburger
        public List<Menu> selectMenu_Hamburger()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from MENU where CATE_ID = 1";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu()
                    {
                        MENU_ID = dr["MENU_ID"].ToString(),
                        MENU_NAME = dr["MENU_NAME"].ToString(),
                        MENU_PRICE = dr["MENU_PRICE"].ToString(),
                        CALORIES = dr["CALORIES"].ToString(),
                        MENU_IMG = dr["MENU_IMG"].ToString(),
                        MENU_DESCRIPTION = dr["MENU_DESCRIPTION"].ToString(),
                        MARK = dr["MARK"].ToString(),
                        CATE_ID = dr["CATE_ID"].ToString()
                    }) ;
                }

            }
            return list;
        }


        //Show Menu_IceCream
        public List<Menu> selectMenu_IceCream()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from MENU where CATE_ID = 2";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu()
                    {
                        MENU_ID = dr["MENU_ID"].ToString(),
                        MENU_NAME = dr["MENU_NAME"].ToString(),
                        MENU_PRICE = dr["MENU_PRICE"].ToString(),
                        CALORIES = dr["CALORIES"].ToString(),
                        MENU_IMG = dr["MENU_IMG"].ToString(),
                        MENU_DESCRIPTION = dr["MENU_DESCRIPTION"].ToString(),
                        MARK = dr["MARK"].ToString(),
                        CATE_ID = dr["CATE_ID"].ToString()
                    });
                }

            }
            return list;
        }

        //Show Menu_Rice
        public List<Menu> selectMenu_Rice()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from MENU where CATE_ID = 3";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu()
                    {
                        MENU_ID = dr["MENU_ID"].ToString(),
                        MENU_NAME = dr["MENU_NAME"].ToString(),
                        MENU_PRICE = dr["MENU_PRICE"].ToString(),
                        CALORIES = dr["CALORIES"].ToString(),
                        MENU_IMG = dr["MENU_IMG"].ToString(),
                        MENU_DESCRIPTION = dr["MENU_DESCRIPTION"].ToString(),
                        MARK = dr["MARK"].ToString(),
                        CATE_ID = dr["CATE_ID"].ToString()
                    });
                }

            }
            return list;
        }

        //Show Nuoc Giai Khat
        public List<Menu> selectMenu_Soda()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from MENU where CATE_ID = 4";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu()
                    {
                        MENU_ID = dr["MENU_ID"].ToString(),
                        MENU_NAME = dr["MENU_NAME"].ToString(),
                        MENU_PRICE = dr["MENU_PRICE"].ToString(),
                        CALORIES = dr["CALORIES"].ToString(),
                        MENU_IMG = dr["MENU_IMG"].ToString(),
                        MENU_DESCRIPTION = dr["MENU_DESCRIPTION"].ToString(),
                        MARK = dr["MARK"].ToString(),
                        CATE_ID = dr["CATE_ID"].ToString()
                    });
                }

            }
            return list;
        }
    }
}
