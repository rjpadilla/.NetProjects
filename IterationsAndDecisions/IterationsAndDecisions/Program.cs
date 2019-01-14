using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            SwitchExample();
            SwitchOnStringExample();
            SwitchOnEnumExample();
            Console.ReadKey();

        }

        static void ForLoopExample()
        {
            //Note1 "i" is only visible within the scope of the for loop,
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is:{0}",i);
            }
            //"i" is not visible here.

        }

        //Iterate array items using foeach.
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //LINQ query!
            var subset = from i in numbers where i< 10 select i;
            Console.WriteLine("Values in subset: ");

            foreach (var i in subset)
            {
                Console.WriteLine("{0} ", i);
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";
            //Test on a lower-class copy of the string.
            while(userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }
        static void DoWhileLoopExample()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); //Note the semicolon!

        }

        //Switch on a numerical value.
        static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2[VB]");
            Console.WriteLine("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well....good luck with that!");
                    break;
                
            }
        }

        static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.WriteLine("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
           
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well....good luck with that!");
                    break;

            }
        }
        static void SwitchOnEnumExample()
        {
            Console.Write("Enter you favorite day of the week:");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Bad input!!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it's not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
            }
        }
    }
}
