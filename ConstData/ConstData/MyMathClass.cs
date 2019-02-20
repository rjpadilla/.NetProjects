using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        //public const double PI = 3.14;
        public static readonly double PI =3.14;

        //public MyMathClass()
        //{
        //    PI = 3.14;
        //}
        
        

        static void LocalConstStringVariable()
        {
            //A local constant data point can be directly accessed
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            //Error!
            //fixedStr = "This will not work!";
        }
    }
}
