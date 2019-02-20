using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNameClash
{
    //Draw to buffer in memory
    public interface IdrawToMemory
    {
        void Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
    }
}
