using System;

namespace UKPO_6
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите координату X верхнего левого угла прямоугольника : ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y верхнего левого угла прямоугольника : ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату X нижнего правого угла прямоугольника : ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y нижнего правого угла прямоугольника : ");
            double y2 = double.Parse(Console.ReadLine());

            try
            {
                Rectangle rectangle = new Rectangle(new Point(x1, y1), new Point(x2, y2));
                Console.WriteLine($"Периметр : {rectangle.Perimeter()}");
                Console.WriteLine($"Площадь : {rectangle.Square()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
