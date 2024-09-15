using System;
namespace UKPO_2
{
    class Program
    {
        static void Main()
        {
            for (double x = -0.4; x <= 1.3; x += 0.1)
            {
                Console.WriteLine(string.Format("f({0}) == {1}", x, Func(x)));
            }
        }

        static double Func(double x) 
        {
            if (x <= 0.5) return Math.Sin(Math.PI / 2);
            return Math.Sin((x - 1) * Math.PI / 2);
        }
    }
}
