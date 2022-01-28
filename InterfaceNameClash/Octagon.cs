using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a printer...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to a memory...");
        }

        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to a form...");
        }
    }
}
