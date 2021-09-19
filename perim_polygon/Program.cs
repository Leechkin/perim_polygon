using System;

namespace perim_polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, r;
            int n;
           
            Console.WriteLine("Введите радиус окружности");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество сторон");
            n = Convert.ToInt32(Console.ReadLine());
            double al = 180 * Math.PI / 180;
            p = n * 2 * r * Math.Sin(al / n);
            Console.WriteLine($"Периметр равен {p}");
        }
    }
}
