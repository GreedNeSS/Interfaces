
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class CurSpeedComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Car car1 && y is Car car2)
                return car1.CurrentSpeed.CompareTo(car2.CurrentSpeed);
            else
                throw new ArgumentException("Parameter is not a Car!");
        }
    }
}
