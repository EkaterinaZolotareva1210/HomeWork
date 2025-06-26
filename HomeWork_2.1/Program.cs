using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int box = c;
            c = b;
            b = a;
            a = box;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
