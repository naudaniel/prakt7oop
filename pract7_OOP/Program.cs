using System;

namespace pract7_OOP
{
    class Program
    {
        public static int Sum(int a, int b = 0, int c = 0)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            //Summa(int, int, int) - сигнатура метода 
            Console.WriteLine(Sum(2, 6, 3));
        }
    }
}
