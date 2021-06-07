using System;

namespace Ex_3
{
    class Program
    {
        //        3. Переворот рядка
        //              Завдання: Напишіть програму для перевороту рядка з використанням рекурсії.
        //              Рядок “abс” перевертається в “cba”.
        static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            return Reverse(s.Substring(1)) + s[0].ToString();
        }


        static void Main(string[] args)
        {
            Console.Write("Введiть текст: ");
            var txt = Console.ReadLine();
            Console.WriteLine("Перевернута строка: " + Reverse(txt));
            Console.ReadLine();
        }
    }
}
