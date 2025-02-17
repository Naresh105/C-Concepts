using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOverloadingTparameter
{
    internal class Program
    {
       
        public void Print(int a)
        {
            Console.WriteLine("Integer: " + a);
        }

        public void Print(double a)
        {
            Console.WriteLine("Double: " + a);
        }

        static void Main()
        {
            Program obj = new Program();
            obj.Print(10);    // Calls Print(int)
            obj.Print(10.5);  // Calls Print(double)
        }


      
    }
}
