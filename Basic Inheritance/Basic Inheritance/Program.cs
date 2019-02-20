﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance ****\n");
            //Make a Car object and set max speed.
            Car myCar = new Car(80);

            //Now make a MiniVan object.
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);
           
            //Set the current speed, and print it.
            myCar.Speed = 50;
            Console.WriteLine(  "My car is going {0} MPH", myCar.Speed);
            Console.ReadLine();
        }
    }
}
