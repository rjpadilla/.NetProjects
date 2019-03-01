using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Car
    {
        //Constant for maximum speed.
        public const int MaxSpeeed = 100;

        //Car Properties.
        public int CurrentSpeed { get; set; } = 100;
        public string PetName { get; set; } = "";

        //Is the car still operational?
        private bool carIsDead;

        //A car has-a radio.
        private Radio theMusicBox = new Radio();

        //Constructors.
        public Car()
        {

        }

        public Car(string name, int speeds)
        {
            CurrentSpeed = speeds;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            //Delegate request to inner object.
            theMusicBox.TurnOn(state);
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
