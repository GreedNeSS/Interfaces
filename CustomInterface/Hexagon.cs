using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Hexagon : Shape, IPointy
    {
        public Hexagon()
        {

        }

        public Hexagon(string name) : base(name)
        {

        }

        public byte Points => 6;

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
    }
}
