﻿using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Vue.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}