using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title = "Home";
            
            return View();
        }
        public IActionResult About() 
        {
            ViewBag.title = "About";
            
            return View();
        }

        public IActionResult ThankYou()
        {
            ViewBag.title = "ThankYou";
            
            return View();
        }
    }
}
