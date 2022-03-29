using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //Fields
        public double _width;
        public double _height;
        private const double defaultWidth = 0;
        private const double defaultHeight = 0;

        //Constructors
        public Rectangle()
        {
            _width = defaultWidth;
            _height = defaultHeight;
        }

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        //Copy Constructor
        public Rectangle(Rectangle rectangle)
        {
            _width = rectangle._width;
            _height = rectangle._height;
        }

        //Destructor
        ~Rectangle()
        {

        }

        //Methods
        public override double CalculateArea()
        {
            double area = 0;
            area = _width * _height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 0;
            perimeter = _width * 2 + _height * 2;
            return perimeter;
        }
        //public static double CalculatePerimeter()
        //{
        //    double perimeter = 0;
        //    return perimeter;
        //}
        public static bool operator <(Rectangle self, Rectangle other)
        {
            return false;
        }
        public static bool operator <=(Rectangle self, Rectangle other)
        {
            return false;
        }
        public static bool operator >(Rectangle self, Rectangle other)
        {
            return false;
        }
        public static bool operator >=(Rectangle self, Rectangle other)
        {
            return false;
        }
        public static bool operator =(Rectangle self, Rectangle other)
        {
            return false;
        }
        public static bool operator !=(Rectangle self, Rectangle other)
        {
            return false;
        }
    }

}
