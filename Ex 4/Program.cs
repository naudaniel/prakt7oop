using System;

namespace Ex_4
{
//    4. Індекс максимального елемента масиву
//          Завдання: Напишіть програму для знаходження індексу максимального елементу
//          масиву з використанням рекурсії.
    class Program
    {
        static int Index(int[] array, int lenght)
        {
            if (lenght == 0)
            {
                return lenght;
            }

            var i = Index(array, lenght - 1);
            return array[lenght] > array[i] ? lenght : i;
        }

        static void Main(string[] args)
        {
            var arr = new[] { 3, 2, 8, 4, 1, 9, 6, 0, 5, 7 };
            Console.WriteLine("Iндекс максимального елемента масива: " + Index(arr, arr.Length - 1));
            Console.ReadLine();
        }
    }
}
