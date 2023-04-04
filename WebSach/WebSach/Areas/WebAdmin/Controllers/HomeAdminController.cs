using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Areas.WebAdmin.Controllers
{
    [Route("api/userdata")]

    public class HomeAdminController : Controller
    {
        private Model1 db = new Model1();
        // GET: WebAdmin/HomeAdmin
        public ActionResult UserCountByMonth()
        {
            var userCounts = db.User
                .GroupBy(u => new { Month = u.Create_at.Value.Month, Year = u.Create_at.Value.Year })
                .Select(g => new { MonthYear = g.Key.Month + "/" + g.Key.Year, Count = g.Count() })
                .OrderBy(g => g.MonthYear)
                .ToList();

            ViewBag.Months = userCounts.Select(uc => uc.MonthYear).ToList();
            ViewBag.UserCounts = userCounts.Select(uc => uc.Count).ToList();

            return View();
        }
    }
}