﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****\n");

            ////Pass two variables in by value.
            //int x = 9, y = 10;
            //Console.WriteLine("Before call: X: {0}, Y: {1}", x,y);
            //Console.WriteLine("Answer is: {0}", Add(x,y));
            //Console.WriteLine("After call: X: {0}, Y: {1}", x,y);
            //Console.ReadLine();

            ////No need to assign initial value to local vairables
            //// used as output parameters, provided the first time
            ////you use them is as output arguements.
            //int ans;
            //Add(90, 90, out ans);
            //Console.WriteLine("90 + 90 = {0}", ans);
            //Console.ReadLine();

            //int i; string str; bool b;
            //FillTheseValues(out i, out str, out b);

            //Console.WriteLine("Int is: {0}", i);
            //Console.WriteLine("String is: {0}", str);
            //Console.WriteLine("Boolean is: {0}", b);
            //Console.ReadLine();

            //string str1 = "Flip";
            //string str2 = "Flop";
            //Console.WriteLine("Before: {0}, {1}", str1,str2);
            //SwapStrings(ref str1, ref str2);
            //Console.WriteLine("After: {0}, {1} ", str1, str2);
            //Console.ReadLine();

            ////Pass in a comma-delimited list of doubles..
            //double average;
            //average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            //Console.WriteLine("Average of data is: {0}", average);

            ////..or pass an array of doubles.
            //double[] data = { 4.0, 3.2, 5.7 };
            //average = CalculateAverage(data);
            //Console.WriteLine("Average of data is: {0}", average);

            ////Average of 0 is 0!
            //Console.WriteLine("Average of data is:{0}", CalculateAverage());
            //Console.ReadLine();

            //EnterLogData("Oh no! Grid can't find data");
            //EnterLogData("Oh no! I can't find the payroll data", "CFO");
            //Console.ReadLine();

            DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Texting...", textColor: ConsoleColor.DarkBlue);
            Console.ReadLine();
        }

        ////Arguments are passed by value b default
        //static int Add(int x,int y)
        //{
        //    int ans = x + y;
        //    //Caller will not see these changes
        //    //as you are modifying a copy of the
        //    //original data.
        //    x = 1000;
        //    y = 88888;
        //    return ans;
        //}

        //Output parameters must be assigned by the called method.
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
           
        }

        //Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        ////Assign a valid value to the parameter or it won't compile
        ////static void ThisWontCompile(out int a)
        //{
        //    Console.WriteLine("Error! Forgot to assign output arg!");
        //}

        //Reference parameters
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        //Return average of "some number" of doubles.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        //static void EnterLogData(string message, string owner = "Programmer")
        //{
        //    Console.Beep();
        //    Console.WriteLine("Error: {0}", message);
        //    Console.WriteLine("Owner of Error: {0}", owner);
        //}

        ////Error! The default value for an optional arg must be known
        ////at compile time!
        //static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DateTime.Now)
        //{
        //    Console.Beep();
        //    Console.WriteLine("Error: {0}", message);
        //    Console.WriteLine("Owner of Error: {0}", owner);
        //    Console.WriteLine("Time of Error: {0}", timeStamp);
        //}

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            //Store old colors to restore after message is printed.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;

            //Set new colors and print message.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            //Restore previous colors.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
