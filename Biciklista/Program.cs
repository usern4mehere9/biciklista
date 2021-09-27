using System;

namespace Biciklista
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, v, v0, s;
            v0 = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());

            s = v0 * 60 + ((a * 3600) / 2);
            v = v0 + (a * 60);

            Console.WriteLine(s);
            Console.WriteLine(v);
        }
    }
}
