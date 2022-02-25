using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    interface IShape
    {
       // public int side { get; set; }
        
        void GetDimensions();
        void CalculateArea();
        void DisplayArea();

    }
}
