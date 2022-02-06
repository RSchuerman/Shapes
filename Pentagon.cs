using System;

namespace Shapes
{
    public class Pentagon
    {
        //Fields
        public double _lengthOfSide;
        private const double defaultLengthOfSide = 0;

        //Constructors
        public Pentagon()
        {
            _lengthOfSide = defaultLengthOfSide;
        }

        public Pentagon(double lengthOfSide)
        {
            _lengthOfSide = lengthOfSide;
        }

        //Copy Constructor
        public Pentagon(Pentagon pentagon)
        {
            _lengthOfSide = pentagon._lengthOfSide;
        }

        //Destructor
        ~Pentagon()
        {

        }

        //Methods
        public double CalculateArea()
        {
            double area = 0;
            area = 0.25 * Math.Sqrt(5 * (5 + Math.Sqrt(20))) * Math.Pow(_lengthOfSide, 2);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            perimeter = _lengthOfSide * 5;
            return perimeter;
        }
    }

}
