using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WhiteRabbit()
        {
            return View();
        }
        public IActionResult ThisIsMe()
        {
            ViewBag.Now = DateTime.Now;
            ViewBag.Name = "Omnia Saeed";
            return View();
        }
    }
}
