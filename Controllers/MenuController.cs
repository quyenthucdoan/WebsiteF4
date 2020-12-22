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
            return View(sc.selectMenu());
        }
        public IActionResult lietKeSanPham()
        {
            return View();
        }
    }
}
