using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comiler errors!
            //Value types cannot be set to null!
            //bool myBool = null;
            //int myInt = null;

            //OK! String are reference types.
            //string myString = null;

            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //Get int from "databnase".
            int? i = dr.GetIntFromDataBase();
            if(i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined.");
            //Get bool from database
            bool? b = dr.GetBoolFromDatatBase();
            if(b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined.");

            //If the value from GetIntFromDatabase() is null,
            //assign local variable to 100.
            int myData = dr.GetIntFromDataBase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            Console.ReadLine();

        }

        static void LocalNullableVariables()
        {
            //Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            //Error!! String are reference types!
            //string ? s = "oop";

            //You can replace '?' suffix with Nullable<T>

        }

        static void TesterMethod(string[] args)
        {
            //We should check for null before accessing the array data!
            if(args != null)
            {
                Console.WriteLine($"You sent me {args.Length} arguments.");
            }

            //Or you can type it like this
            Console.WriteLine($"You sent me {args?.Length} arguements");

            //If you want to print an actual value, you could leverage the null coalescing operto to assign a default value as so:
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
        }
    }
}
