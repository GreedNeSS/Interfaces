using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new();

            foreach (Car item in garage)
            {
                Console.WriteLine(item.PetName);
                Console.WriteLine(item.CurrentSpeed);
            }

            Console.WriteLine();

            foreach (Car item in garage.GetTheCars(true))
            {
                Console.WriteLine(item.PetName);
                Console.WriteLine(item.CurrentSpeed);
            }
        }
    }
}
