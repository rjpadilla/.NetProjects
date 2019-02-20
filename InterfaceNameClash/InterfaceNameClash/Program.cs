using System;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes ******\n");
            //All of these invocations call the same Draw() method!
            Octagon oct = new Octagon();

            IDrawToForm itForm = (IDrawToForm)oct;
            itForm.Draw();

            IDrawToPrinter itfPriner = (IDrawToPrinter)oct;
            itfPriner.Draw();

            IdrawToMemory itfMemory = (IdrawToMemory)oct;
            itfMemory.Draw();

            Console.ReadLine();
        }
    }
}
