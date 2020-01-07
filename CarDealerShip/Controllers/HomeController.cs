using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CarDealerShip.Models;

namespace CarDealerShip.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}