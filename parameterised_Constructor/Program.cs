using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterised_Constructor
{
   
       public class Person
     {
            private string name;
            private int age;

            // Default constructor
            public Person()
            {
                name = "Unknown";
                age = 0;
            }

            // Parameterized constructor
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

           public static void Main(String[] args)
            {
            Person person = new Person();   
                Console.WriteLine("Name: " + person.name);
                Console.WriteLine("Age: " + person.age);
            }
        }
    }

