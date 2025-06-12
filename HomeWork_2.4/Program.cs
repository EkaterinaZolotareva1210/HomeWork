using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 1000;
            int b = (n/100) % 10;
            int c = (n/10) % 10;
            int d = n % 10;
            int n2 = a * 1000 + d * 100 + c * 10 + b;
            Console.WriteLine(n2);
            Console.ReadKey();
        }
    }
}
