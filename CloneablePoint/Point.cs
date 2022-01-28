using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription Desc { get; set; } = new();

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, string name) : this(x, y)
        {
            Desc.Name = name;
        }

        public override string ToString()
        {
            return $"X = {X}; Y = {Y}; Name = {Desc.Name};\nID = {Desc.PointId}\n";
        }

        //public object Clone()
        //{
        //    Point newPoint = new(X, Y, Desc.Name);
        //    return newPoint;
        //}

        public object Clone()
        {
            Point newPoint = (Point)MemberwiseClone();

            PointDescription description = new() { Name = Desc.Name };
            newPoint.Desc = description;
            return newPoint;
        }
    }

    class PointDescription
    {
        public string Name { get; set; }
        public Guid PointId { get; set; }

        public PointDescription()
        {
            Name = "No-name";
            PointId = Guid.NewGuid();
        }
    }
}
