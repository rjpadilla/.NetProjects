using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    public class Car:IComparable
    {
        //Constant for maximum speed.
        public const int MaxSpeeed = 100;

        //Car Properties.
        public int CurrentSpeed { get; set; } = 100;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        //Is the car still operational?
        private bool carIsDead;

        //A car has-a radio.
       // private Radio theMusicBox = new Radio();

       
        //Constructors.
        public Car()
        {

        }

        public Car(string name, int speeds)
        {
            CurrentSpeed = speeds;
            PetName = name;
        }

        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        //IComparable implementation.
        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            //if (temp != null)
            //{
            //    if (this.CarID > temp.CarID)
            //        return 1;
            //    if (this.CarID < temp.CarID)
            //        return -1;
            //    else
            //        return 0;
            //}
            //else
            //    throw new ArgumentException("Parameter is not a Car!");
            if (temp != null)
                return this.CarID.CompareTo(temp.CarID);
            else
                throw new ArgumentException("Parameter is not a Car1");
        }
        //See if Car has overheated.
        public void Accelerate(int delta)
        {
            //if(carIsDead)
            //    Console.WriteLine("{0} is out of order...", PetName);
            //else
            //{
            //    CurrentSpeed += delta;
            //    if(CurrentSpeed > MaxSpeeed)
            //    {
            //        //Console.WriteLine("{0} has overheated!", PetName);
            //        CurrentSpeed = 0;
            //        carIsDead = true;
            //        //We need to call the HelpLink property, thus we need to create a local variable before throwing the Exception object.
            //        Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
            //        ex.HelpLink = "http://www.CarsRUs.com";

            //        //Stuff in custom data regarding the error.
            //        ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
            //        ex.Data.Add("Cause", "You have a lead foot.");

            //        throw ex;

            //        ////Use the "throw" keyword to raise an exception.
            //        //throw new Exception(string.Format("{0} has overheated!!", PetName));
            //    }
            //    else
            //        Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);

            //}
            //CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You hav a lead foot", DateTime.Now);
            //ex.HelpLink = "http://www.CarsRUs.com";
            //throw ex;
        }
    }
}
