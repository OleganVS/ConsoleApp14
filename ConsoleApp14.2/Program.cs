using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._2
{
    internal class Program
    {
        static double GetGeron(double x, double y, double z)
        { 
            double p = (x + y + z)/2;
            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine()); 
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetGeron(x1, y1, z1);
            Console.WriteLine("Введите длины сторон второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine()); 
            double y2 = Convert.ToDouble(Console.ReadLine()); 
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetGeron(x2, y2, z2);
            Console.WriteLine("s1 = {o}, s2 = {1}", GetGeron (x1, y1, z1), GetGeron(x2, y2, z2));
            Console.ReadKey();
        }
    }
}
