using System;
using System.ComponentModel;
using System.Net.NetworkInformation;


   

namespace SingleLevelInheritance
{
   //parent class
    class Vehicle
    {
        public void WhiteCar()
        {
            Console.WriteLine("This White car.");
        }
    }

    // Child Class
    class Car : Vehicle
    {
        public void RedCar()
        {
            Console.WriteLine("This is Red Car.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Child Class
            Car myCar = new Car();

            // Access method of the Parent Class
            myCar.WhiteCar();

            // Access method of the Child Class
            myCar.RedCar();

            Console.ReadLine();
        }
    }
}
