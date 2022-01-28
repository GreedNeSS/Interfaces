using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Parking : IEnumerable
    {
        Car[] cars = new Car[4];

        public Parking()
        {
            cars[0] = new("Bugi", 90);
            cars[1] = new("Hurt", 50);
            cars[2] = new("Monster", 40);
            cars[3] = new("Reggi", 80);
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("GetEnumerator");
            return new CarEnumerator(cars);
        }
    }

    class CarEnumerator : IEnumerator
    {
        Car[] cars;
        int position = -1;

        public CarEnumerator(Car[] cars)
        {
            this.cars = cars;
        }
        public object Current => cars[position];

        public bool MoveNext()
        {
            if (position < cars.Length - 1 )
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset() => position = -1;
    }
}
