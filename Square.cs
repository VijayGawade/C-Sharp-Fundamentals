using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class Square
    {
        public double Side { get; private set; }
        public double Area { get; private set; }

        public Square(int side)
        {
            Side = side;
            CalculateArea();
        }

        private void CalculateArea()
        {
            Area = Side * Side;
        }
    }
}
