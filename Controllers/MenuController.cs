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
            return View(sc.selectMenu_Hamburger());
        }


        public IActionResult Menu_Hamburger()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_Hamburger());
        }

        public IActionResult Menu_IceCream()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_IceCream());
        }

        public IActionResult Menu_Rice()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_Rice());
        }

        public IActionResult Menu_Soda()
        {
            StoreContext sc = new StoreContext();
            return View(sc.selectMenu_Soda());
        }
    }
}
