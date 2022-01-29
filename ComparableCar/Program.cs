using System;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            cars[0] = new Car("Rusty", 80, 1);
            cars[1] = new Car("Mary", 30, 234);
            cars[2] = new Car("Viper", 40, 34);
            cars[3] = new Car("Mel", 50, 4);
            cars[4] = new Car("Chucky", 90, 5);

            Console.WriteLine("Here is the unordered set of cars:");
            foreach (var car in cars)
                Console.WriteLine($"ID: {car.CarID}, PetName: {car.PetName}, " +
                    $"CurrentSpeed: {car.CurrentSpeed}");

            Console.WriteLine("\nHere is the ordered set of cars:");
            Array.Sort(cars);
            foreach (var car in cars)
                Console.WriteLine($"ID: {car.CarID}, PetName: {car.PetName}, " +
                    $"CurrentSpeed: {car.CurrentSpeed}");

            Console.WriteLine("\nOrdering by pet name:");
            Array.Sort(cars, Car.SortByPetName());
            foreach (var car in cars)
                Console.WriteLine($"ID: {car.CarID}, PetName: {car.PetName}, " +
                    $"CurrentSpeed: {car.CurrentSpeed}");

            Console.WriteLine("\nOrdering by Current Speed:");
            Array.Sort(cars, Car.SortByCurSpeed());
            foreach (var car in cars)
                Console.WriteLine($"ID: {car.CarID}, PetName: {car.PetName}, " +
                    $"CurrentSpeed: {car.CurrentSpeed}");
        }
    }
}
