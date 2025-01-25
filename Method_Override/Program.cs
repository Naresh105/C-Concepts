using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Method_Override
{
    internal class Program { }
    
            public class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }
        
public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The dog barks.");
            }
        static void Main(string[] args) { 
            Animal myAnimal = new Dog();
                myAnimal.Speak(); // Output: "The dog barks."

        }

}}
