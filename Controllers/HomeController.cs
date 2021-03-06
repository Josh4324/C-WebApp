﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SquareWeb.Models;

namespace SquareWeb.Controllers
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

        [HttpPost]
        public IActionResult Index(string firstNumber, string secondNumber)
        {
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);
            if (numberOne < 0 || numberTwo < 0)
            {
                ViewBag.ErrorMessage = "Invalid Number Entered";
                return View();
            }
            else
            {
                float result1 = Convert.ToSingle((Math.Sqrt(numberOne)));
                float result2 = Convert.ToSingle((Math.Sqrt(numberTwo)));
                ViewBag.number1 = numberOne;
                ViewBag.number2 = numberTwo;
                ViewBag.Result = result1;
                ViewBag.Result1 = result2;
                return View();
            }

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
