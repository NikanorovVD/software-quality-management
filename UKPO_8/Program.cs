using System;
using System.Collections.Generic;

namespace UKPO_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<MainsVoltage> voltages = new()
            {
                new Voltage220V(2, "T1", 440),
                new Voltage360V("T2", 180)
            };

            Console.WriteLine(string.Join(Environment.NewLine, voltages));
        }
    }
}
