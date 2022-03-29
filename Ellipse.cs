using System;

namespace Shapes
{
    public class Ellipse : Shape
    {
        //Fields
        public double _semiMajorAxis;
        public double _semiMinorAxis;
        private const double defaultSemiMajorAxis = 0;
        private const double defaultSemiMinorAxis = 0;

        //Constructors
        public Ellipse()
        {
            _semiMajorAxis = defaultSemiMajorAxis;
            _semiMinorAxis = defaultSemiMinorAxis;
        }

        public Ellipse(double semiMajorAxis, double semiMinorAxis)
        {
            _semiMajorAxis = semiMajorAxis;
            _semiMinorAxis = semiMinorAxis;
        }

        //Copy Constructor
        public Ellipse(Ellipse ellipse)
        {
            _semiMajorAxis = ellipse._semiMajorAxis;
            _semiMinorAxis = ellipse._semiMinorAxis;
        }

        //Destructor
        ~Ellipse()
        {

        }

        //Methods
        public override double CalculateArea()
        {
            double area = 0;
            area = Math.PI * _semiMajorAxis * _semiMinorAxis;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 0;
            double approximation1 = 0;
            double approximation2 = 0;
            double approximation3 = 0;
            double h = Math.Pow((_semiMajorAxis - _semiMinorAxis), 2) / Math.Pow((_semiMajorAxis + _semiMinorAxis), 2);

            approximation1 = 2 * Math.PI * Math.Sqrt((Math.Pow(_semiMajorAxis, 2) + Math.Pow(_semiMinorAxis, 2))/2);
            approximation2 = Math.PI* (3 * (_semiMajorAxis + _semiMinorAxis) - Math.Sqrt((3 * _semiMajorAxis + _semiMinorAxis) * (_semiMajorAxis + 3 * _semiMinorAxis)));
            approximation3 = Math.PI * (_semiMajorAxis + _semiMinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
            perimeter = (approximation1 + approximation2 + approximation3)/3;
            return perimeter;
        }
    }
}
