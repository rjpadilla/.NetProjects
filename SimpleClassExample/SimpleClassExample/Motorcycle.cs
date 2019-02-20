using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        //New members to represent the name of the driver.
        public string driverName;
        public void SetDriverName(string name)
        {
            //this.name = name; Same as
            driverName = name;
        }

        public void PopAWheely()
        {
            for(int i =0; i<= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaeeeww");
            }
        }

        //Put back the default constructor, which will
        // set all data members to default vaulues.
        //public Motorcycle() { }

        //Our custom constructor.
        //public Motorcycle(int intensity)
        //{
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //}

        //public Motorcycle(int intensity, string name)
        //{
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        //Constructor chaining.
        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }
        public Motorcycle(int intensity) : this(intensity, "")
        {
            Console.WriteLine("In ctor taking an int");

        }
        public Motorcycle(string name) : this(0, name)
        {
            Console.WriteLine("in ctor taking a string");
        }

        //This is the 'master' constructor that does all the real work
        public Motorcycle(int intesity, string name)
        {
            Console.WriteLine("In master ctor");
            if (intesity > 10)
            {
                intesity = 10;
            }
            driverIntensity = intesity;
            driverName = name;
        }

        //Single constructor using optional args.
        //public Motorcycle(int intensity = 0, string name = "")
        //{
        //    if(intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

    }
}
