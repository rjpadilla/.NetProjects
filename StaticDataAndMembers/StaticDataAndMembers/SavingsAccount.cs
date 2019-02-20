using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    //A simple savings account
    class SavingsAccount
    {
        //Instance-level data.
        public double currBalance;
        public static double currInterestRate;

        ////A static point of data
        //public static double currInterestRate = 0.04;

        //Notice that our constructor is setting 
        //the static currInteresRate value



        public SavingsAccount(double balance)
        {
            //currInterestRate = .04; //This is static data!
            currBalance = balance;
        }

        //A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static cto!");
            currInterestRate = .04;
        }

        //Static members to get/set interset rate.
        public static void SetInterestRate(double newrate)
        {
            currInterestRate = newrate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
