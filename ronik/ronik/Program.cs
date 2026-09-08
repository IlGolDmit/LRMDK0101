using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ronik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                a = b;
            }
            if (a < c)
            {
                a = c;
            }
            Console.WriteLine("Максимальное: " + a);
        }
    }
}
