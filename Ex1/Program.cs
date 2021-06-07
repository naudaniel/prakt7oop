using System;

namespace Ex1
{
    class Program
    {
        //1. Арифметична прогресія
        //      Завдання: Написати програму для виводу n перших членів арифметичної прогресії
        //      1, 2, 3… з використанням рекурсивного методу.
        static uint AlgPr(uint n)
        {
            if (n == 0)
            {
                return 1;
            }

            return AlgPr(n - 1) + 1; ;
        }

        static string Recursive(uint i, uint n)
        {
            if (i > n) return "";
            return $"{i} {Recursive(i + 1, n)}";
        }
         
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var N = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Recursive(1, N));

            //for (uint i = 0; i < N; i++)
            //{
            //    Console.Write(AlgPr(i) + " ");
            //}
        }
    }
}
