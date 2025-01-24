using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_inheritance
{
   

class Vehicle
        {
            public void Engine()
            {
                Console.WriteLine("The heart of the vehicle is considered to be the engine .");
            }
        }

        class Car : Vehicle
        {
            public void Diesel()
            {
                Console.WriteLine("Car feul is Diesel");
            }
        }

        class Bike : Vehicle
        {
            public void Petrol()
            {
                Console.WriteLine("Bike feul is Petrol.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car obj1 = new Car();
            obj1.Engine();
                obj1.Diesel(); // Accessing derived class method

                Bike obj2 = new Bike();
                obj2.Engine(); // Accessing base class method
                obj2.Petrol(); // Accessing derived class method
            }
        }
    }
   
