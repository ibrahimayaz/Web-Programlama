﻿using Kurs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kurs.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}