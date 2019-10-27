/*
 * @author Sumit Aggarwal - 000793607
 * I certify that all work done in the assignment is my own work and that I have not copied it
 * from any other source. I also certify that I have not allowed anyone else to copy my code.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{/// <summary>
/// creates a Rectangle class which inherits the property Area and CalculateArea() method from class Shape
/// </summary>
    class Rectangle:Shape
    {
        private double length;
        private double width;

        public double Length //length of the rectangle
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Length)} must be > 0");
                }

                length = value;
            }
        }

        public double Width //width of the rectangle
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Width)} must be > 0");
                }

                width = value;
            }
        }

        public Rectangle(string type,double length, double width)
            :base(type)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()// calculates the area of the rectangle and rounds it to two
            //decimal places
        {
            Area = Math.Round(length * width,2);
            return Area;
        }

        public override double CalculateVolume()// no volume for 2D shapes
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Rectangle\t2D\t\t {length}x{width}\t\t\t {CalculateArea()} \n";
        }
    }
}
