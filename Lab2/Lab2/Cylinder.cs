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
/// creates a Cylinder class which inherits the property Radius from the Circle class
/// </summary>
    class Cylinder:Circle
    {
        private double height;

        public double Height //height of the cylinder, else it will become a circle
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Height)} must be > 0");
                }
                height = value;
            }
        }

        public Cylinder(string type,double radius,double height)
            : base(radius,type)
        {
            Height = height;
        }

        public override double CalculateArea()// calculates the surface area of the cylinder and rounds it
            //two decimal places
        {
            Area = Math.Round(2 * PI * Radius * Height + 2 * PI * Math.Pow(Radius, 2),2);
            return Area;
        }

        public override double CalculateVolume()// calculates the volume of the cylinder and rounds it to
            //two decimal places
        {
            Volume = Math.Round(PI * Height * Math.Pow(Radius, 2),2);
            return Volume;
        }

        public override string ToString()
        {
            return $"Cylinder\t3D\t\t {Radius}x{height}\t\t\t {CalculateArea()}\t\t {CalculateVolume()}\n";
        }
    }
}
