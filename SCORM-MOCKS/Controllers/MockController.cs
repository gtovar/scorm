﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCORM_MOCKS.Controllers
{
    public class MockController : Controller
    {
        // GET: Mock
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult General()
        {
            return View();
        }
        public ActionResult Individual()
        {
            return View();
        }
        public ActionResult Individual_Examen()
        {
            return View();
        }
        public ActionResult Examen()
        {
            return View();
        }
    }
}