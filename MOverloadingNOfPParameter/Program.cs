using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOverloadingNOfPParameter
{
    internal class Program
    {



        // Method with one parameter
        public void Display(int a)
        {
            Console.WriteLine("Integer: " + a);
        }

        // Overloaded method with two parameters
        public void Display(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        static void Main()
        {
            Program obj = new Program();
            obj.Display(10);      // Calls first method
            obj.Display(10, 20);  // Calls overloaded method
        }



    }
}
