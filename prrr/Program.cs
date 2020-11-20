using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y = 0;
            while (y <= 15)
            {
                double y1 = x + y;
                y = y1;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y1 = " + y1);
                x += 0.2;
            }
            Console.ReadKey();
        }
    }
}
