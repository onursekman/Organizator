using OrganizatorBLL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganizatorUI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message_()
        {
            //List<SelectListItem> email = new List<SelectListItem>();

            //foreach (var item in PeopleBLL.listPeople())
            //{
            //    email.Add(new SelectListItem { Text = item.Email, Value = item.ID.ToString() });
            //}

            //ViewBag.Email = email;
            return View();
        }
        [HttpPost]
        public ActionResult Message_(string email,string detail)
        {
            People gonderen = Session["People"] as People;
            People people = PeopleBLL.GetPeople(email);
            if (people.Email.Trim()== email.Trim())
            {
                Message msj = new Message();
                msj.SenderID = gonderen.ID;
                msj.ReceiverID = people.ID;
                msj.Message_Detail = detail;
                MessageBLL.SenderMessage(msj);


            }
            return RedirectToAction("Index","Home");
        }


    }
}