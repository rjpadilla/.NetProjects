﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        struct Point
        {
            //Fields of the structure.
            public int X;
            public int Y;

            //A cuton constructor.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }

            //Add 1 to the(X,Y) position.
            public void Increment()
            {
                X++; Y++;
            }

            //Subtract 1 from the (X,Y) position.
            public void Decrement()
            {
                X--;Y--;
            }

            //Display the current position.
            public void Display()
            {
                Console.WriteLine("X = {0}, Y={1}", X,Y);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            //Creaate an initial Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            //Error! Did not assign Y value. Don't do this
            //Point p1;
            //p1.X = 10;
            //p1.Display

            //OK! Both fields assigned before use. This is good
            // p2.X = 10;
            //p2.Y=10;
            //p2.Display

            //Adjust the X and Y values
            myPoint.Increment();
            myPoint.Display();

            //Set all fields to default values using the default constructor.
            Point p1 = new Point();

            //Prints X=0, Y=0.
            p1.Display();

            //Call custom constructor.
            Point p2 = new Point(50, 60);
            //Prints X=50, Y=60.
            p2.Display();
            Console.ReadLine();
        }

        
    }
}
