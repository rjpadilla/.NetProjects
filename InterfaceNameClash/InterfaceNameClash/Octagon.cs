using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNameClash
{
     class Octagon:IDrawToForm,IdrawToMemory,IDrawToPrinter
    {
        public void Draw()
        {
            //Shared drawing logic.
            Console.WriteLine("Drawing the Octagon...");
        }
    }
}
