using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угол в градусах: ");
            int deg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты угла: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды угла: ");
            int sec = Convert.ToInt32(Console.ReadLine());

            double a_deg = deg + (min + sec / 60) / 60;
            double a_rad = (a_deg * Math.PI) / 180;
            Console.Write("Значение угла в радианах: {0}", a_rad);
            Console.ReadKey();

        }
    }
}
