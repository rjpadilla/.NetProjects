using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //Managers need to know their number of stock options
    class Manager:Employee
    {
        public int StockOptions { get; set; }

        //public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
        //{
        //    //This proper is defined by the manager class.
        //    StockOptions = numbOfOpts;

        //    //Assign incoming paramerters using inherited properties of the parent class.
        //    ID = empID;
        //    Age = age;
        //    Name = fullName;
        //    Pay = currPay;
            
        //    //This would be a compiler erro, if the SSN propert were read-only!
        //    //SocialSecurityNumber = ssn;
            
        //}

        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts) : base(fullName, age, empID, currPay, ssn)
        {
            //This property is defined in the manager class.
            StockOptions = numbOfOpts;
        }

        public Manager() { }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
           
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
            
        }
    }
}
