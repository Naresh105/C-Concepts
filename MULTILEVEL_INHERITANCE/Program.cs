using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTILEVEL_INHERITANCE
{
   
            class Vehicle  // Base class
        {
            public void speed()
            {
                Console.WriteLine("Vehicle is running on the road........");
            }
        }

        class Car : Vehicle  // Derived class from Vehicle
        {
            public void Break()
            {
                Console.WriteLine("Car Stops...");
            }
        }

        class NanoCar : Car  // Derived class from Car (and indirectly from Vehicle)
        {
            public void Clutch()
            {
                Console.WriteLine("temporarily disconnect the engine power from the transmission...");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                NanoCar Move = new NanoCar();
                Move.speed();    // Inherited from Vehicle
                Move.Break();  // Inherited from Car
                Move.Clutch();   // Defined in NanoCar class
            }
        }

    }

