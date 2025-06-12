using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Через запятую введите длину трубы в метрах: ");
            double length = Convert.ToDouble(Console.ReadLine());
            double length_m = Math.Ceiling(length);
            Console.WriteLine(length_m);
            Console.ReadKey();
        }
    }
}
