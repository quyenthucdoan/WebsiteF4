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
        static string conString = @"Data Source=localhost;Initial Catalog=FRAMEWORK ;Integrated Security=True";

        //Admin Add Menu
        public int InsertMenu(Menu m)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"insert into MENU values('{m.MENU_NAME}',{m.MENU_SIZE},{m.MENU_PRICE},{m.CALORIES},'{m.MENU_IMG}','{m.MENU_DESCRIPTION}',1,{m.CATE_ID})";
                return cmd.ExecuteNonQuery();
            }
        }

        public List<Menu> select_to_edit(int id)
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from MENU where MENU_ID={id}";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu()
                    {
                        MENU_ID = dr["MENU_ID"].ToString(),
                        MENU_NAME = dr["MENU_NAME"].ToString(),
                        MENU_SIZE = dr["MENU_SIZE"].ToString(),
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

        public int Delete_Menu(int id)
        {

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"delete from MENU where MENU_ID = {id}";
                    int count = cmd.ExecuteNonQuery();
                    return count;
                }
            }
        }

        public List<Menu> select_Menu()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from MENU";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Menu()
                    {
                        MENU_ID = dr["MENU_ID"].ToString(),
                        MENU_NAME = dr["MENU_NAME"].ToString(),
                        MENU_SIZE = dr["MENU_SIZE"].ToString(),
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

        //Show MENU_Hamburger
        public List<Menu> selectMenu_FastFood()
        {
            List<Menu> list = new List<Menu>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from MENU where CATE_ID = 5";
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
                conn.Close();
            }
            return list;
        }


        public List<Menu> detail_menu(int id)
        {
            List<Menu> list = new List<Menu>();

            using(SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = $"select * from menu where MENU_ID = {id}";
                    cmd.Connection = conn;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        list.Add(new Menu
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
            }

            return list;
        }

        public int Update_Menu(Menu m)
        {
            int check = 0;
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"update Menu set Menu_Name='{m.MENU_NAME}',Menu_Size={m.MENU_SIZE},Menu_Price={m.MENU_PRICE},Calories={m.CALORIES},Menu_IMG='{m.MENU_IMG}',Menu_Description='{m.MENU_DESCRIPTION}',Mark={m.MARK},CATE_ID={m.CATE_ID} where Menu_id={m.MENU_ID}";
                    check = cmd.ExecuteNonQuery();
                }
            }
            return check;
        }

        //public int Update_Menu(string MENU_ID, string MENU_NAME, int MENU_SIZE, string MENU_PRICE, string CALORIES, string MENU_IMG, string MENU_DESCRIPTION, string MARK, string CATE_ID)
        //{
        //    int check = 0;
        //    using (SqlConnection conn = new SqlConnection(conString))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = conn;
        //            cmd.CommandText = $"update Menu set Menu_Name='{MENU_NAME}',Menu_Size={MENU_SIZE},Menu_Price={MENU_PRICE},Calories={CALORIES},Menu_IMG='{MENU_IMG}',Menu_Description='{MENU_DESCRIPTION}',Mark={MARK},CATE_ID={CATE_ID} where Menu_id={MENU_ID}";
        //            check = cmd.ExecuteNonQuery();
        //        }
        //    }
        //    return check;
        //}
    }
}
