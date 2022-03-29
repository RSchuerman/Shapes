using System;

namespace Shapes
{
    public class Square : Shape
    {
        //Fields
        public double _lengthOfSide;
        private const double defaultLengthOfSide = 0;

        //Constructors
        public Square()
        {
            _lengthOfSide = defaultLengthOfSide;
        }

        public Square(double lengthOfSide)
        {
            _lengthOfSide = lengthOfSide;
        }

        //Copy Constructor
        public Square(Square square)
        {
            _lengthOfSide = square._lengthOfSide;
        }

        //Destructor
        ~Square()
        {

        }

        //Methods
        public override double CalculateArea()
        {
            double area = 0;
            area = _lengthOfSide * _lengthOfSide;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 0;
            perimeter = _lengthOfSide * 4;
            return perimeter;
        }

    }
}
