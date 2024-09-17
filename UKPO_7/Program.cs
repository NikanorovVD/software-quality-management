using System;
using System.Collections.Generic;


namespace UKPO_7
{
    public class Program
    {
        const string person = "Петров";
        static void Main()
        {
            List<Resident> table = new()
            {
                new (1_111_111, "Иванов", "Айсберг", 5),
                new (2_222_222, "Петров", "Элегант", 7),
                new (2_222_222, "Петров", "Элегант", 3),
                new (3_333_333, "Сидоров", "Айсберг", 1),
                new (2_222_222, "Петров", "Айсберг", 3),
            };


            Console.WriteLine(string.Join(Environment.NewLine, table));
            Console.Write("Введите название отеля : ");
            string hotel = Console.ReadLine();

            int days = table.DaysStayOfPersonInHotel(person, hotel);
            Console.WriteLine(days);
        }
    }
}
