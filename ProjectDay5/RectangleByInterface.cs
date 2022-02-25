using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay5
{
    class RectangleByInterface : IShape
    {
          void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }
}
