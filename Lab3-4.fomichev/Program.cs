//средний уровень 8
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double start = -1.0;
        double end = 3.0;
        double step = 0.2;

        List<double> yValues = new List<double>();

        for (double x = start; x <= end; x += step)
        {
            double y;

            if (x > 1.5)
            {
                y = x;
            }
            else if (x >= 0)
            {
                y = 2 * Math.Pow(x, 2) * Math.Cos(2 * x);
            }
            else // x < 0
            {
                y = Math.Pow(Math.E, -Math.Cos(3 * x));
            }

            yValues.Add(y);
            Console.WriteLine($"x = {x:F1}, y = {y:F4}");
        }

        
    }
}