using System;

namespace Ex3
{
    class Program
    {
        //3. Множення чисел
        //  Завдання: Напишіть перевантажені методи, у скороченій формі(лямбда), які
        //  приймають на вхід дві цілі числа, перемножують їх та в залежності від типу додають до
        //  результату: 1 – для uint, 2 – для int, 3 – для long.

        
        public static uint multiply(uint x, uint y) => x * y + 1;
        public static int multiply(int x, int y) =>  x * y + 2;
        public static long multiply(long x, long y) => x * y + 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Integers:" + multiply(5,4));
            Console.WriteLine("UIntegers:" + multiply((uint)4,(uint)7));
            Console.WriteLine("Longs:" + multiply((long)8,(long)4));
        }
    }
}
