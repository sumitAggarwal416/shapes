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
/// creates a Circle class which inherits the property Area and CalculateArea() method from Shape class
/// </summary>
    class Circle:Shape
    {
        private double radius;

        public double Radius // radius of the circle
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Radius)} must be > 0");
                }

                radius = value;
            }
        }

        public Circle(double radius, string type)
            : base(type)
        {
            Radius = radius;
        }

        public override double CalculateArea()// calculates the area of the circle and rounds it to two 
            //decimal places
        {
            Area = Math.Round(PI * radius * radius,2);
            return Area;
        }

        public override double CalculateVolume() // no volume for 2D shapes
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Circle\t\t2D\t\t {Radius}\t\t\t {CalculateArea()} \n";
        }
    }
}
