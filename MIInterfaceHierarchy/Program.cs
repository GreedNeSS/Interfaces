using System;

namespace MIInterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new();
            Square square = new();

            rectangle.Draw();
            ((IDrawable)square).Draw();
            ((IPrintable)square).Draw();
        }
    }
}
