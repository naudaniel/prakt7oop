using System;

namespace Ex_2
{
    class Program
    {
        //        2. Сума n перших членів арифметичної прогресії
        //              Завдання: Напишіть програму для отримання суми n перших членів арифметичної
        //              прогресії.Різницю прогресії d задавати в якості параметру.
        static uint AlgPr(uint n, uint d)
        {
            if (n == 0)
            {
                return d;
            }

            return AlgPr(n - 1, d) + d;
        }


        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.Write("d = ");
            var d = Convert.ToUInt32(Console.ReadLine());

            var sum = 0u;
            for (var i = 0u; i < n; i++)
            {
                sum += AlgPr(i, d);
            }

            Console.WriteLine($"Сума {n} перших членiв арифметичноi прогресii дорiвнює {sum}");
            Console.ReadLine();
        }
    }
}
