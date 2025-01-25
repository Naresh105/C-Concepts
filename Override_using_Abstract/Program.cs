using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Override_using_Abstract
{
   
            public abstract class Shape
        {
            public abstract double GetArea();
        }

public class Circle : Shape
        {
            private double _radius;

            public Circle(double radius)
            {
                _radius = radius;
            }

            public override double GetArea()
            {
                return Math.PI * _radius * _radius;
            }
        
        static void Main(string[] args) { 
                Shape myShape = new Circle(5);
                Console.WriteLine(myShape.GetArea()); // Output: Area of the circle

        }
}
}
