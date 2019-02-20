using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        //The hidden int backing field is set to one!
        public int NumberOfCars { get; set; } = 1;

        ////The hidden Car backing field is set to null!
        //public Car MyAuto { get; set; }

        //The hidden backing field is set to a new Car object.
        public Car MyAuto { get; set; } = new Car();
        //Must use constructors to override default
        //values assigned to hidden backing fields.
        public Garage()
        {
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }

    }
}
