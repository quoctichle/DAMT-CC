﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSach.Areas.WebAdmin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: WebAdmin/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}