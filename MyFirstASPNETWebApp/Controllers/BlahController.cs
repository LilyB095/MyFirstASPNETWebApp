using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FanMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FanMail(FanMailModel model)
        {
            return View();
        }
    }
}
