using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Default_Constuctor
{
   

        class Person
        {
            private string name;

            // Default constructor
            public Person()
            {
                name = "Unknown"; // Default value for the name
                Console.WriteLine("Default constructor called.");
            }
        // Method
            public void Display()
            {
                Console.WriteLine("Name: " + name);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create an object using the default constructor
                Person person = new Person();
                person.Display(); // Output: Name: Unknown
            }
        }
    }

