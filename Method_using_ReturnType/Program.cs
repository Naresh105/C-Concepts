using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_using_ReturnType
{
    public class Program
    {
       
            static void Main(string[] args)
            {
                int result = AddNumbers(5, 10);
                Console.WriteLine("The sum is: " + result); 
            // Output: The sum is: 15
            }

            static int AddNumbers(int num1, int num2)
            {
                return num1 + num2;
            }
        }

    }

