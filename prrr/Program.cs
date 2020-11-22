using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Формула y1 = x + y");
            Console.ReadKey();
            double x = 1;
            double y = 0;
            while (x <= 10)
            {
               
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                double y1 = x + y;
                Console.WriteLine("Результат = " + y1);
                x += 2;
                y += 2;
            }
            Console.ReadKey();
        }
    }
}
