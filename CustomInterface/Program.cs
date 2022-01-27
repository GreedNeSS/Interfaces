using System;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Hexagon(), new Circle(),
                new Triangle("Joe"), new Circle("Jojo")};

            IPointy firstPointyItem = FindFirstPointyShape(shapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();

                if (shapes[i] is IPointy pointy)
                {
                    Console.WriteLine("-> Points: {0}", pointy.Points);
                }
                else
                {
                    Console.WriteLine("-> {0}\'s not pointy!", shapes[i].PetName);
                }

                if (shapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)shapes[i]);
            }
        }

        static IPointy FindFirstPointyShape(Shape[] args)
        {
            foreach (var item in args)
            {
                if (item is IPointy pointy)
                {
                    return pointy;
                }
            }
            return null;
        }

        static void DrawIn3D(IDraw3D itf3D)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3D.Draw3D();
        }
    }
}
