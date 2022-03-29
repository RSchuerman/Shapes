using System;

namespace Shapes
{
    public class Circle : Shape
    {
        //Fields
        public double _radius;
        private const double defaultRadius = 0;

        //Constructors
        public Circle()
        {
            _radius = defaultRadius;
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        //Copy Constructor
        public Circle(Circle circle)
        {
            _radius = circle._radius;
        }

        //Destructor
        ~Circle()
        {

        }

        //Methods
        public override double CalculateArea()
        {
            double area = 0;
            area = _radius * _radius * Math.PI;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 0;
            perimeter = _radius * 2 * Math.PI;
            return perimeter;
        }
    }
}
