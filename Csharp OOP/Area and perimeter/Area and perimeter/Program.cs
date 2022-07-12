using System;


namespace Area_and_perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sampleRadius = 120;
            int sampleLength = 85;
            int sampleWidth = 45;

            Circle circleVar = new Circle(sampleRadius);

            Rectangle rectangleVar = new Rectangle(sampleLength, sampleWidth);

            Console.WriteLine("Area of circle = " + circleVar.calculateArea());
            Console.WriteLine("Perimeter of circle = " + circleVar.calculatePerimeter());
            Console.WriteLine("Area of Rectangle = " + rectangleVar.calculateArea());
            Console.WriteLine("Perimeter of Rectangle = " + rectangleVar.calculatePerimeter());

            Console.ReadKey();
        }
    }
}