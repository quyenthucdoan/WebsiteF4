using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsiteF4.Models;

namespace WebsiteF4.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult ShowMenu()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_FastFood());
        }


        public IActionResult Menu_FastFood()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_FastFood());
        }

        public IActionResult Menu_IceCream()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_IceCream());
        }

        public IActionResult Menu_Fruit()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_Rice());
        }

        public IActionResult Menu_Soda()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_Soda());
        }

        public IActionResult Detail_Each_Item_In_Menu(int id)
        {
            StoreContext sc = new StoreContext();

            return View(sc.detail_menu(id));
        }
    }
}
