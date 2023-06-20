﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace GamesWeb.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }


        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // Original
        //public string Index()
        //{
        //    //return "This is my default action...";
        //}
        //public string Welcome(string name, int ID = 1)
        //{
        //    //return "This is the Welcome action method...";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}
    }
}
