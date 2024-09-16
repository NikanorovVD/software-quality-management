using System;
using System.Collections.Generic;
using System.Linq;

namespace UKPO_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите нижнюю границу диапазона : ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Введите верхнюю границу диапазона : ");
            int max = int.Parse(Console.ReadLine());

            List<int> simple = new();
            for (int x = min; x <= max; x++)
            {
                if (IsSimple(x)) simple.Add(x);
            }

            Console.WriteLine("Простые числа:");
            Console.WriteLine(GetArrayString(simple));
        }

        private static bool IsSimple(int x)
        {
            for (int i = 2; i < x / 2; i++)
                if (x % i == 0) return false;
            return true;
        }

        private static string GetArrayString<T>(IEnumerable<T> array)
        {
            return $"Кол-во : {array.Count()}{Environment.NewLine}" +
                   $"Элементы : {string.Join(", ", array)}";
        }
    }
}
