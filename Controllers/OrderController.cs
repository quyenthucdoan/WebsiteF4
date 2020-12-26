using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteF4.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Order1()
        {
            return View();
        }

        public IActionResult Order2()
        {
            return View();
        }
    }
}
