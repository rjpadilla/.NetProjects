using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            //Print the current interest rate.
            Console.WriteLine("Interest Rate is : {0}", SavingsAccount.GetInterestRate());
            SavingsAccount s2 = new SavingsAccount(100);

            
            //Try to change the interest rate via property.
            SavingsAccount.SetInterestRate(.08);

           


            //Make new object, this does NOT 'rest' the interest rate
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
