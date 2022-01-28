using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        int IShape.GetNumberOfSide => 4;

        void IDrawable.Draw()
        {
            Console.WriteLine("Draw in a IDrawable...");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Draw in a IPrintable...");
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Print...");
        }
    }
}
