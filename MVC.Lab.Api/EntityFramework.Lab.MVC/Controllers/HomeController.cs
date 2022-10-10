﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework.Lab.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gifs()
        {
            return View();
        }

        public ActionResult About()
        {   
            ViewBag.Message = "My application description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact me";

            return View();
        }
    }
}