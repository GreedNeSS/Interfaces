using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car : IComparable
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new();
        public int CarID { get; set; }

        public Car()
        {

        }

        public Car(string name, int speed, int id)
        {
            PetName = name;
            CurrentSpeed = speed;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int  delta)
        {
            if (carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    Exception ex = new($"{PetName} has overheated!");
                    ex.HelpLink = "http://www.carsRus.com";

                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                }
                else
                {
                    Console.WriteLine($"Current speed: {CurrentSpeed}");
                }
            }
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj is Car car)
        //    {
        //        if (this.CarID > car.CarID)
        //        {
        //            return 1;
        //        }
        //        else if (this.CarID < car.CarID)
        //        {
        //            return -1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Parameter is not a Car!");
        //    }
        //}

        public int CompareTo(object obj)
        {
            if (obj is Car car)
            {
                return this.CarID.CompareTo(car.CarID);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }

        public static IComparer SortByPetName() => (IComparer)new PetNameComparer();
        public static IComparer SortByCurSpeed() => (IComparer)new CurSpeedComparer();
    }
}
