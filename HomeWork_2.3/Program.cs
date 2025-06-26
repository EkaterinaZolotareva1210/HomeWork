using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mm_inch = 25.4;
            Console.Write("Введите длину отрезка в дюймах: ");
            int inch_length = Convert.ToInt32(Console.ReadLine());
            double mm_length = inch_length * mm_inch;
            double mmeter = Math.Round(mm_length % 10, 1);
            double meter = Math.Truncate(mm_length / 1000);
            double cmeter = Math.Abs(meter * 100 - Math.Truncate(mm_length / 10));
            Console.WriteLine("Длина отрезка: {0} метров, {1} сантиметров, {2} миллиметров", meter, cmeter, mmeter);
            Console.ReadKey();

        }
    }
}
