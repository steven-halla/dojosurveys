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
        [HttpPost]
        [Route("submitinfo")]
        public IActionResult Index(string Name, string Location, string FavoriteLanguage, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.FavoriteLanguage = FavoriteLanguage;
            ViewBag.Comment = Comment;
           
        }
    }
}
