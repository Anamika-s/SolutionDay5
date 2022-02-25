using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    class Triangle : Shape
    {

        //int? x = 10;
        int Base, height;

        public override void GetDimensions()
        {

            Console.WriteLine("Enter Value of Base");
            int.TryParse(Console.ReadLine(), out Base);
            Console.WriteLine("Enter Value of height");
            int.TryParse(Console.ReadLine(), out height);

        }
        public override void CalculateArea()
        {
            area = (int).5*(Base * height);
        } 
    }
}
