using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierachy
{
    interface IPrintable
    {
        void Print();
        void Draw(); //Not possible name clash here!!!
    }
}
