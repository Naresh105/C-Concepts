using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOverloadingOparameter
{
    internal class Program
  
    {
        public void Show(string name, int age)
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }

        public void Show(int age, string name)
        {
            Console.WriteLine("Age: " + age + ", Name: " + name);
        }

        static void Main()
        {
            Program obj = new Program();
            obj.Show("Alice", 25);  // Calls first method
            obj.Show(30, "Bob");    // Calls second method
        }


       
    }
}
