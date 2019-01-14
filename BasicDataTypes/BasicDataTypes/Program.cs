using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BigInteger lives here!
using System.Numerics;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Data Declarations:");
            //Local variables a re declared and initialized as follows:
            //dataType varName = initialValue;
            int myInt = 0;

            // You can also declare and assign on two lines.
            string myString;
            myString = "This is my character data";

            //Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            //Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            BoolsOnlyOptions();
            CharFunctionality();
            ParseFromStrings();
            UseDatesAndTimes();
            UseBigInteger();

            Console.ReadKey();

            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to creat variables:");
            bool b = new bool(); // Sets to false
            int i = new int();  // Sets to 0.
            double d = new double(); // Sets to 0.
            DateTime dt = new DateTime(); //Sets to 1/1//0001 12:00:00AM
            Console.WriteLine("{0}, {1}, {2}, {3}",b,i,d,dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            //A C# int is really a shorthand for System.Int32, 
            // which inherits the following members from System.Object.

            Console.WriteLine("=> System Object Functionality:");

            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.GetHashCode() = {0}", 12.Equals(23));
            Console.WriteLine("12.GetHashCode() = {0}", 12.ToString());
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetType());
            Console.WriteLine();

        }

        static void DataTypeFunctionality()
        {
            //Check Max or Min
            Console.WriteLine("=>Data type Functionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min od double {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }

        static void BoolsOnlyOptions()
        {
            //Bool doesn't have max or min just True or False
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality: ");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There',5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There',6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();

        }

        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");

            //This constructor takes year, month, day).
            DateTime dt = new DateTime(2015, 10, 17);

            //What days of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            //Monthis is now Decemeber
            dt = dt.AddMonths(2);
            Console.WriteLine("Dayligh savings: {0}", dt.IsDaylightSavingTime());

            //This constructor takes (hours, minutes, seconds).
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            //Subtract 15 minutes from the current TimeSpan and 
            // print the result.
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
        }
        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy = BigInteger.Parse("999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value? {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("888888888888888888888888888"));
            Console.WriteLine("Value of reallyBigIs: {0}", reallyBig);
        }
    }
}
