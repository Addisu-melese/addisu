﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult blogSingle()
        {
            return View();
        }
        public IActionResult portfoliodetail()
        {
            return View();
        }
        public IActionResult portfoliodetail1()
        {
            return View();
        }
        public IActionResult portfoliodetail2()
        {
            return View();
        }
        public IActionResult experiancecv(string password,string name)
        {
            List<string> pass = new List<string>();
            pass.Add(name);
            pass.Add(password);
            return View(pass);
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
