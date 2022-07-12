using System;

namespace Area_and_perimeter
{
    class Circle : ShapeBase
    {
        private static double PI = 3.14;
        public double radius { get; set; }

        public Circle(int rad)
        {
            radius = rad;
        }

        public override double calculateArea()
        {
            double area;
            area = PI * (radius * radius);
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter;
            perimeter = 2 * PI * radius;
            return perimeter;
        }

    }
}