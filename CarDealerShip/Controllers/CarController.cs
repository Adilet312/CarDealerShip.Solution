using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using CarDealerShip.Models;

namespace CarDealerShip.Controllers
{
    public class CarController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAllCars();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create(string model, string color, DateTime date, double price)
        {
            Car myCar = new Car(model, color, date, price);
            return RedirectToAction("Index");
        }
    }
}