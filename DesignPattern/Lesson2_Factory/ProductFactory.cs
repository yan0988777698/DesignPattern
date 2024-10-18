using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson2_Factory
{
    public interface IProduct
    {
        void ChangeColor(string color);
    }
    public class Bike : IProduct
    {
        private string color = "black";
        public Bike()
        {
            
        }
        public void ChangeColor(string color)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return $"This bike is {color} color.";
        }
    }
    public class Car : IProduct
    {
        private string color = "black";
        public Car()
        {

        }
        public void ChangeColor(string color)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return $"This car is {color} color.";
        }
    }
    public static class ProductFactory
    {
        public static IProduct Create(string product)
        {
            switch (product)
            {
                case "Car":
                    return new Car();
                case "Bike":
                    return new Bike();
                default:
                    throw new Exception("Error product name.");
            }

        }
        public static void Demo()
        {
            IProduct car = ProductFactory.Create("Car");
            Console.WriteLine(car);
            car.ChangeColor("red");
            Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
