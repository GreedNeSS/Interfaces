using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
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
            return cars.GetEnumerator();
        }
    }
}
