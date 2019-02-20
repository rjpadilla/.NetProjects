using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Automatic Properties *****\n");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();

            //Put car in the garage.
            Garage g = new Garage();
            g.MyAuto = c;
            ////OOk, prints default value of zero.
           Console.WriteLine("Number of Cars: {0}",g.NumberOfCars);

            //Runtime error! Backing field is currently nulll!
            //Console.WriteLine(g.MyAuto.PetName);

            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}
