using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_inC
{
    internal class Program
    {

        class OverloadingExample
        {
            // Method with one parameter
            public void Display(int a)
            {
                Console.WriteLine("Integer: " + a);
            }

            // Method with two parameters
            public void Display(int a, double b)
            {
                Console.WriteLine("Integer: " + a + ", Double: " + b);
            }

            // Method with a different type of parameter
            public void Display(string message)
            {
                Console.WriteLine("Message: " + message);
            }

            static void Main()
            {
                OverloadingExample obj = new OverloadingExample();

                obj.Display(10);
                obj.Display(10, 20.5);
                obj.Display("Hello, C#");

                Console.ReadLine();
            }
        }
    }
}

