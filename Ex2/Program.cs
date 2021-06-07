using System;

namespace Ex2
{
    class Program
    {

        static double Max(double a,double b,double c)
        {
            return Max(a, Max(b, c));
        }
        static double Max(double a, double b)
        {
            return Math.Max(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Enter first number(x):");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number(y):");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number(z(enter 0 for two value)):");
            double z = double.Parse(Console.ReadLine());

            if (z == 0)
                Console.WriteLine("Max value: " + Max(x, y));
            else
                Console.WriteLine("Max value: " + Max(x,y,z));
        }
    }
}
