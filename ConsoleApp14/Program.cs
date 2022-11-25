using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void GetParamsCube(double h, out double v, out double s)
        {
            v = h * h * h;
            s = 6 * h * h;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту ребра куба");
            double h = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCube (h, out s, out v);
            Console.WriteLine("{0} {1}" ,s,v);
            Console.ReadKey();

        }
    }
}
