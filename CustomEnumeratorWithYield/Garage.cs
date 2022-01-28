using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Garage : IEnumerable
    {
        Car[] cars = new Car[4];

        public Garage()
        {
            cars[0] = new("Bugi", 90);
            cars[1] = new("Hurt", 50);
            cars[2] = new("Monster", 40);
            cars[3] = new("Reggi", 80);
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("GetEnumerator");
            foreach (var item in cars)
            {
                yield return item;
            }
        }

        public IEnumerable GetTheCars(bool returnRevers)
        {
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                if (returnRevers)
                {
                    for (int i = cars.Length; i != 0; i--)
                    {
                        yield return cars[i - 1];
                    }
                }
                else
                {
                    foreach (var item in cars)
                    {
                        yield return item;
                    }
                }
            }
        }
    }
}
