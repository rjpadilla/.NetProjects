using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class OutherClass
    {
        //A public nested type can be used by anybody.
        public class PublicInnterClass { }

        //A private nested type can only be used by memebers of the containing class.
        private class PrivateInnerClass { }
    }
}
