using System;
using System.Collections.Generic;
using System.Text;

namespace LB4_2
{
    class Rectangle 
    {
        public int side { get; set; } = 0;
        public Rectangle(int side) => this.side = side;

    }
    class RectangleComparer : IComparer<Rectangle>
    {
        public int Compare(Rectangle r1, Rectangle r2)
        {
            if (r1.side > r2.side)
                return 1;
            else if (r1.side < r2.side)
                return -1;
            else
                return 0;
        }
    }
    class RectangleComparerDesc : IComparer<Rectangle>
    {
        public int Compare(Rectangle r1, Rectangle r2)
        {
            if (r1.side > r2.side)
                return -1;
            else if (r1.side < r2.side)
                return 1;
            else
                return 0;
        }
    }
}
