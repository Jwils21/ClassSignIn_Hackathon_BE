﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassSignIn_Hackathon_BE.Controllers {
	public class HomeController: Controller {
		public ActionResult Index() {
			ViewBag.Title = "Home Page";

			return View();
		}
	}
}
