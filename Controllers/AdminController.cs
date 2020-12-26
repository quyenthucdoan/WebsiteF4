using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteF4.Models;
namespace WebsiteF4.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Xu_Ly_Order()
        {
            return View();
        }

        public IActionResult Check()
        {
            return View();
        }

        public IActionResult MENU_ADD1(Menu m)
        {
            StoreContext sc = new StoreContext();
            int check = 0;
            if (m.MENU_NAME != null)
            {
                check = sc.InsertMenu(m);
            }
            
            if (check > 0)
            {
                ViewBag.ThongBao = "Thanh cong";
            }
            else ViewBag.ThongBao = "That bai";
            return View();
        }

        public IActionResult WatchFood()
        {
            StoreContext sc = new StoreContext();

            return View(sc.select_Menu());
        }

        public IActionResult Detele_Menu(int id)
        {
            StoreContext sc = new StoreContext();
            int count = sc.Delete_Menu(id);
            if (count > 0) ViewBag.ThongBaoDelete = "Thanh cong";
            else ViewBag.ThongBaoDelete = "That bai";
            return Redirect("/Admin/WatchFood");
        }

        public IActionResult Edit_Menu(int id)
        {
            StoreContext sc = new StoreContext();
            
            return View(sc.select_to_edit(id));
        }

        [HttpPost]
        public IActionResult Update_Menu(Menu m)
        {
            //string MENU_ID, string MENU_NAME, int MENU_SIZE, string MENU_PRICE, string CALORIES, string MENU_IMG, string MENU_DESCRIPTION, string MARK, string CATE_ID
            StoreContext sc = new StoreContext();
            //MENU_ID, MENU_NAME, MENU_SIZE, MENU_PRICE, CALORIES, MENU_IMG, MENU_DESCRIPTION, MARK, CATE_ID
            int check = sc.Update_Menu(m);
            if(check > 0)
            {
                ViewBag.ThongBaoUpdate = "Thanh cong";
            }
            else
            {
                ViewBag.ThongBaoUpdate = "That bai";
            }
            return View();
        }
    }
}
