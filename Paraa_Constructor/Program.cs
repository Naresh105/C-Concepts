﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraa_Constructor
{
    
    
        class Car
        {
            public string model;

            // Create a class constructor with a parameter
            public Car(string modelName)
            {
                model = modelName;
            }

            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang");
                Console.WriteLine(Ford.model);
            }
        }
    }

   