﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingWithOksana.Models;

namespace TestingWithOksana.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
//Ik ben hier geweest
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
            //Examen afgewerkt
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
