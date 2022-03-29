using System;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Rectangle rectA = new Rectangle();
            rectA._width = 5;
            rectA._height = 10;
            double rectArea = rectA.CalculateArea();
            double rectPerimeter = rectA.CalculatePerimeter();
            Console.WriteLine("RECTANGLE:  Area: " + rectArea + " Perimeter: " + rectPerimeter);

            Square squareA = new Square();
            squareA._lengthOfSide = 5;
            double squareArea = squareA.CalculateArea();
            double squarePerimeter = squareA.CalculatePerimeter();
            Console.WriteLine("SQUARE:  Area: " + squareArea + " Perimeter: " + squarePerimeter);

            Circle circleA = new Circle();
            circleA._radius = 5;
            double circleArea = circleA.CalculateArea();
            double circlePerimeter = circleA.CalculatePerimeter();
            Console.WriteLine("CIRCLE:  Area: " + circleArea + " Perimeter: " + circlePerimeter);

            Ellipse ellipseA = new Ellipse();
            ellipseA._semiMajorAxis = 5;
            ellipseA._semiMinorAxis = 10;
            double ellipseArea = ellipseA.CalculateArea();
            double ellipsePerimeter = ellipseA.CalculatePerimeter();
            Console.WriteLine("ELLIPSE:  Area: " + ellipseArea + " Perimeter: " + ellipsePerimeter);

            Pentagon pentagonA = new Pentagon();
            pentagonA._lengthOfSide = 5;
            double pentagonArea = pentagonA.CalculateArea();
            double pentagonPerimeter = pentagonA.CalculatePerimeter();
            Console.WriteLine("PENTAGON:  Area: " + pentagonArea + " Perimeter: " + pentagonPerimeter);

            return;
        }
    }
}
