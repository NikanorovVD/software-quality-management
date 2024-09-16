using System;
using System.Collections.Generic;
using System.Linq;

namespace UKPO_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите нижнюю границу диапазона : ");
            int min = int.Parse(Console.ReadLine());
            if (min < 100_000) min = 100_000;

            Console.Write("Введите верхнюю границу диапазона : ");
            int max = int.Parse(Console.ReadLine());
            if (max > 999_999) max = 999_999;

            List<int> result = new();
            for (
                int x = min;
                x <= max;
                x++
                )
            {
                int first_three = x / 1000;
                int second_three = x % 1000;
                if (TreeDigitNumberSum(first_three) == TreeDigitNumberSum(second_three))
                    result.Add(x);
            }

            if (result.Any()) Console.WriteLine(string.Join(Environment.NewLine, result));
            else Console.WriteLine("Требуемых чисел нет");

            int TreeDigitNumberSum(int number)
            {
                return number / 100 + number % 100 / 10 + number % 10;
            }
        }
    }
}
