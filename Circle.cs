using System;

namespace Shapes
{
    public class Circle
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
        public double CalculateArea()
        {
            double area = 0;
            area = _radius * _radius * Math.PI;
            return area;
        }

        public double CalculateCircumference()
        {
            double perimeter = 0;
            perimeter = _radius * 2 * Math.PI;
            return perimeter;
        }
    }
}
