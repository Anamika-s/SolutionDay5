using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    class Square : Shape
    {

        //int? x = 10;
        int side;
        
        public override void GetDimensions()
        {

            Console.WriteLine("Enter Value of side");
            int.TryParse(Console.ReadLine(), out side);
            
        }
        public override void CalculateArea()
        {
            area = side * side;
        } 
    }
}
