using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteF4.Models
{
    public class Menu
    {
        public int MENU_ID;
        public string MENU_NAME;
        public int MENU_SIZE;
        public string MENU_PRICE;

        public Menu() { }
        public Menu(string b, int c, string d)
        {
            MENU_NAME = b;
            MENU_SIZE = c;
            MENU_PRICE = d;
        }
        public Menu (int a, string b, int c, string d)
        {
            MENU_ID = a;
            MENU_NAME = b;
            MENU_SIZE = c;
            MENU_PRICE = d;
        }
    }
}
