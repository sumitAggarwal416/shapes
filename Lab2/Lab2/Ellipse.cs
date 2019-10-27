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
/// creates an Ellipse class which inherits the property Area and CalculateArea() method from class Shape
/// </summary>
    class Ellipse:Shape
    {
        private double r1;
        private double r2;

        public double R1 //first axis of the ellipse
        {
            get
            {
                return r1;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(R1)} must be > 0");
                }
                r1 = value;
            }
        }

        public double R2 //second axis of the ellipse
        {
            get
            {
                return r2;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(R2)} must be > 0");
                }
                r2 = value;
            }
        }

        public Ellipse(string type,double r1, double r2)
            : base(type)
        {
            R1 = r1;
            R2 = r2;
        }

        public override double CalculateArea() //calculates the area of the ellipse and rounds it to two
            // decimal places
        {
            Area =Math.Round( PI * r1 * r2,2);
            return Area;
        }

        public override double CalculateVolume() // no volume for 2D SHAPES
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Ellipse\t\t2D\t\t {R1}x{R2}\t\t\t {CalculateArea()}\n";
        }
    }
}
