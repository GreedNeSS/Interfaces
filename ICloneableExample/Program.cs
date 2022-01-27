using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            OperatingSystem operatingSystem = new(PlatformID.Win32NT, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn =
              new System.Data.SqlClient.SqlConnection();

            CloneMe(str);
            CloneMe(operatingSystem);
            CloneMe(sqlCnn);
            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is a: {c.GetType().Name}");
        }
    }
}
