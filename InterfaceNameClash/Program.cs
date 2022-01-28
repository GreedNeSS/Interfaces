using System;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon octagon = new();

            IDrawToForm drawToForm = (IDrawToForm)octagon;
            drawToForm.Draw();

            if (octagon is IDrawToMemory drawToMemory)
                drawToMemory.Draw();

            if (octagon is IDrawToPrinter drawToPrinter)
                drawToPrinter.Draw();
        }
    }
}
