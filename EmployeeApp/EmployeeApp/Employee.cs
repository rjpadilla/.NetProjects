using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //Field data.
        private string empName;
        private int empID;
        private float currPay;
        private string empSSN;

        //New field and property.
        private int empAge;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }



        ////Accessor (get method)
        //public string GetName()
        //{
        //    return empName;
        //}

        ////Mutator (set method)
        //public void SetName(string name)
        //{
        //    //Do a check on incoming value
        //    //before making assignment.
        //    if (name.Length > 15)
        //    {
        //        Console.WriteLine("Error ! Name length exceeds 15 characters!");
        //    }
        //    else
        //    {
        //        empName = name;
        //    }
        //}

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string SocialSecurityNumber { get { return empSSN; } }

        ////Constructors
        //public Employee()
        //{

        //}
        //public Employee(string name, int id, float pay)
        //{
        //    empName = name;
        //    empID = id;
        //    currPay = pay;
        //}

        //Updated constructors.
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            //Better! Use properties when setting class data.
            //This reduces the amount of duplicate error checks.
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;

            //Oops! This is no longer possible if the property is read only.
            //SocialSecurityNumber = ssn;

            //Check incoming ssn parameter as required and then set the value.
            //empSSN = ssn;
          
        }

        //Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}",empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
