using OrganizatorBLL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganizatorUI.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comment_()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Comment_(int id,string detail)
        { People people = Session["People"] as People;
            Comment co = new Comment();
            co.Comment_detail = detail;
            co.PeopleID = people.ID;
            int CommentId = CommentBLL.CommentId();
            Comment_Organizasyon org = new Comment_Organizasyon();
            org.OrganizasyonID = id;
            org.ComentID = CommentId;
            CommentBLL.InsertComment(co);
            CommentBLL.InsertComment_Organizasyon(org);

            return RedirectToAction("Index","Home");
        }
    }
}