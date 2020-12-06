using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dojosurveys.Models;

namespace dojosurveys.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("success")]
        public IActionResult Success(string Name, string Location, string FavLanguage, string Comment)
        {
            // ViewBag.Name = Name;
            // ViewBag.Location = Location;
            // ViewBag.FavLang = FavLanguage;
            // ViewBag.Comment = Comment;
            // return View();
            return View();
        }
       
    }
}
