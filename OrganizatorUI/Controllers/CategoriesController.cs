using OrganizatorBLL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganizatorUI.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult InsertCategories()
        {
            return View();

        }
        [HttpPost]
        public ActionResult InsertCategories(string CategoriesName,string picture)
        {
            Categories c = new Categories();
            c.CategoriesName = CategoriesName;
            c.Picture = picture;
            CategoriesBLL.insertCategories(c);

            return RedirectToAction("Index","Home");

        }
    }
}