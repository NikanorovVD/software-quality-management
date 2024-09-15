using System;
using System.Linq;
using System.Collections.Generic;

namespace UKPO_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите кол-во строк массива : ");
            int rows_count = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов массива : ");
            int columns_count = int.Parse(Console.ReadLine());

            Random random = new();
            int[,] table = new int[rows_count, columns_count];
            List<int> alternating_сolumns = new();

            for (int i = 0; i < rows_count; i++)
            {
                for (int j = 0; j < columns_count; j++)
                {
                    table[i, j] = random.Next() % 2;
                }
            }

            for (int i = 0; i < columns_count; i++)
            {
                bool two_equals_in_raw = false;
                for (int j = 1; j < rows_count; j++)
                {
                    if (table[j, i] == table[j - 1, i])
                    {
                        two_equals_in_raw = true;
                        break;
                    }
                }

                if (!two_equals_in_raw)
                    alternating_сolumns.Add(i);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows_count; i++)
            {
                for (int j = 0; j < columns_count; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Номера строго чередующихся столбцов(0-based): " +
                $"{(alternating_сolumns.Any() ? string.Join(' ', alternating_сolumns) : "отсутствуют")}");
        }
    }
}
