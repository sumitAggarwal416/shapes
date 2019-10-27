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
/// creates the class Triangle that inherits from the Shape class properties Area and CalculateArea() method
/// </summary>
    class Triangle:Shape
    {
        private double edge; 
        private double height;

        public double Edge // public property for the edge of the traingle
        {
            get
            {
                return edge;
            }
            set
            {
                if (value <= 0) //validates that the user enters a non-zero and non-negative value
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Edge)} must be >0");
                }
                edge = value;
            }
        }

        public double Height // public property for the height of the traingle
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0) //validates that the user enters a non-zero and non-negative value
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Height)} must be >0");
                }
                height = value;
            }
        }
        public Triangle(string type,double edge,double height)
            : base(type)
        {
            Edge = edge;
            Height = height;
        }

        public override double CalculateArea() //calculates the area of the traingle and rounds the
            //answer to two deciaml places
        {
            Area = Math.Round(0.5 * edge * height,2);
            return Area;
        }

        public override double CalculateVolume() // 2D shape do not have a volume
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Triangle\t2D\t\t {Edge}x{Height}\t\t\t{CalculateArea()}\n";
        }
    }
}
