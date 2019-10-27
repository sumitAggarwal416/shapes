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
/// creates the Square class that inherits from the Shape class the property Area and CalculateArea() method 
/// </summary>
    class Square:Shape
    {
        private double side;

        public double Side //side of the square
        {
            get
            {
                return side;
            }
            set
            {
                if (value <= 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Side)} must be > 0");
                }
                side = value;
            }
        }

        public Square(string type, double side)
            : base(type)
        {
            Side = side;
        }

        public override double CalculateArea()// calculates the area of the square and rounds it to two
            //decimal places
        {
            Area = Math.Round(side * side,2);
            return Area;
        }

        public override double CalculateVolume()// no volume for the 2D shapes
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Square\t\t2D\t\t {Side}\t\t\t {CalculateArea()}\n";
        }
    }
}
