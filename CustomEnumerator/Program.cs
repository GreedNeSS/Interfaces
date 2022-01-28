using System;
using System.Collections;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new();

            foreach (Car item in garage)
            {
                Console.WriteLine(item.PetName);
            }

            Console.WriteLine();
            
            Parking parking = new();

            foreach (Car item in parking)
            {
                Console.WriteLine(item.PetName);
            }

            Console.WriteLine();

            IEnumerator enumerator = parking.GetEnumerator();
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");

            Console.WriteLine("\nenumerator.Reset();\n");
            enumerator.Reset();

            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
            Console.WriteLine($"enumerator.MoveNext(): {enumerator.MoveNext()}");
            Console.WriteLine($"((Car)enumerator.Current).PetName:" +
                $" {((Car)enumerator.Current).PetName}");
        }
    }
}
