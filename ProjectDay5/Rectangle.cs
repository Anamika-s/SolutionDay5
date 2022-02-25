using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    class Rectangle : Shape
    {

        //int? x = 10;
        int length , breadth;

        public override void GetDimensions()
        {

            Console.WriteLine("Enter Value of length");
            int.TryParse(Console.ReadLine(), out length);
            Console.WriteLine("Enter Value of breadth");
            int.TryParse(Console.ReadLine(), out breadth);

        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }
        
    }
}
