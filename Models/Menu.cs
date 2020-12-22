using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteF4.Models
{
    public class Menu
    {
        public string MENU_ID { get; set; }
        public string MENU_NAME { get; set; }
        public string MENU_SIZE { get; set; }
        public string MENU_PRICE { get; set; }
        public string CALORIES { get; set; }
        public string MENU_IMG { get; set; }
        public string MENU_DESCRIPTION { get; set; }
        public string MARK { get; set; }
        public string CATE_ID { get; set; }

        public Menu()
        {
            MENU_ID = null;
            MENU_NAME = null;
            MENU_SIZE = null;
            MENU_PRICE = null;
            CALORIES = null;
            MENU_IMG = null;
            MENU_DESCRIPTION = null;
            MARK = null;
            CATE_ID = null;
        }


        public Menu(string id, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8)
        {
            MENU_ID = id;
            MENU_NAME = a1;
            MENU_SIZE = a2;
            MENU_PRICE = a3;
            CALORIES = a4;
            MENU_IMG = a5;
            MENU_DESCRIPTION = a6;
            MARK = a7;
            CATE_ID = a8;
        }

        
    }
}
