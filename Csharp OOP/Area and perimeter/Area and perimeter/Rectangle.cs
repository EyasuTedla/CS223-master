using System;

namespace Area_and_perimeter
{
    class Rectangle : ShapeBase
    {
        public double length { get; set; }

        public double width { get; set; }

        public Rectangle(int len, int wid)
        {
            length = len;
            width = wid;
        }

        public override double calculateArea()
        {
            double area;
            area = length * width;
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter;
            perimeter = 2 * (length + width);
            return perimeter;
        }

    }
}