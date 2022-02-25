using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    abstract class Shape
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

}