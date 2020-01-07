using System.Collections.Generic;
using System;

namespace CarDealerShip.Models
{
    public class Car
    {
        private string model;
        private string color;
        private DateTime date;
        private double price;
        private static List<Car> carList = new List<Car> {};

        public Car(string  model, string color , DateTime date, double price) 
        {
            this.model = model;
            this.color = color;
            this.date = date;
            this.price = price;
            carList.Add(this);
        }

        public static List<Car> GetAllCars()
        {
            return carList;
        }

        public static void RemoveCars()
        {
            carList = null;
            // carList.Clear() would delete all the items from the list.
        }

        public string GetModel()
        {
            return this.model;
        }

        public void SetModel(string new_model)
        {
            this.model = new_model;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string new_color)
        {
            this.color = new_color;
        }

        public string GetDate()
        {
            return this.date.ToString("MMMM dd, yyyy");
        }

        public void SetDate(DateTime new_date)
        {
            this.date = new_date;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double new_price)
        {
            this.price = new_price;
        }

        public string ToString()
        {
            string output = "Model: "+this.model+", Color: "+this.color+", Date: "+
            GetDate() +", Price: "+this.price;
            return output;
        }

    }
}