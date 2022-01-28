using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapImage image = new();

            image.Draw();
            image.DrawInBoundingBox(3, 5, 6, 7);
            image.DrawUpsideDown();
        }
    }
}
