using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Areas.WebAdmin.Controllers
{
    public class AdminReactionsController : Controller
    {
        // GET: Home
        List<Reaction> _cmt = new List<Reaction>();
        public AdminReactionsController()
        {

            _cmt.Add(new Reaction() { Comment_Id = 1, Comment_content = "Cmt A", Parent = 0 });
            _cmt.Add(new Reaction() { Comment_Id = 2, Comment_content = "reply Cmt A", Parent = 1 });
            _cmt.Add(new Reaction() { Comment_Id = 3, Comment_content = "reply Cmt A", Parent = 2 });
            _cmt.Add(new Reaction() { Comment_Id = 4, Comment_content = "Cmt B", Parent = 0 });
            _cmt.Add(new Reaction() { Comment_Id = 5, Comment_content = "reply Cmt B", Parent = 4 });

        }
        public ActionResult Index()
        {
            ViewBag.data = _cmt;
            return View();
        }

        [ChildActionOnly]
        public ActionResult _ChildComment(int id)
        {
            var data = _cmt.Where(s => s.Parent == id).ToList();
            return PartialView("_ChildComment", data);
        }
    }

}
