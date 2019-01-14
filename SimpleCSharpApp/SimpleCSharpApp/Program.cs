﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;



            ////Display a simple message to the user.
            //Console.WriteLine("***** My First C# App *****");
            //Console.WriteLine("Hello World!");

            ////Wait for Enter key to be presssed before shutting down.
            //Console.ReadLine();


        }

        static void ShowEnvironmentDetails()
        {
            //Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);

            Console.WriteLine(".NET Version: {0}:", Environment.Version);
        }
    }
}
