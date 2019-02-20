using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNameClash
{
    //Render to the printer.
    public interface IDrawToPrinter
    {
        void Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
    }
}
