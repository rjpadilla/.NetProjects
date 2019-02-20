using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
   partial class Employee
    {
        //Derived classses can now directly access this informationl..
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard,Gold,Platinum
            }
            //Assume we have other members that represent dental/health benefits, and so on
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
        
    }
}
