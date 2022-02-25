using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    class Circle : Shape
    {
        int radius, height;

        public override void CalculateArea()
        {
            area = (int)3.14 * (radius * radius * height);
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter Radius");
            int.TryParse(Console.ReadLine(), out radius);
            Console.WriteLine("Enter Height");
            int.TryParse(Console.ReadLine(), out height);
        }
    }
}
