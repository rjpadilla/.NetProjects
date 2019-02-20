﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;


            //Assume Manager has a constructor matching this signature:
            //(string fullName ,int age, int empId, float currPay, string ssn, int nobOfOPts)
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();


            //Create and use the public innner class. OK! 
            OutherClass.PublicInnterClass inner;

            

           

            Console.ReadLine();
        }

        static void CastingExamples()
        {
            //A Manager "is-a" System.Object, so we can store a Manager reference in an ojbect variable just fine
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            //A Manager "is-an" Emplyee too.
            Employee moonUnit = new Manager("MoonUnite Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
            //A PTSalesPerson "is-a" SalesPerson
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            //Increae pay...
            //Give new parking space in company garage....
            Console.WriteLine("{0} was promoted!", emp.Name);
        }
    }
}
