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
/// creates the Box class which inherits the properties Length and Width from the Rectangle class
/// </summary>
    class Box:Rectangle
    {
        private double height;

        public double Height //height of the box
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)// validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Height)} must be > 0");
                }
                height = value;
            }
        }
        public Box(string type, double length, double width, double height)
            :base(type,length,width)
        {
            Height = height;
        }

        public override double CalculateArea() // caculates the surface area of the box and rounds it to
            //two decimal places
        {
            Area = Math.Round(2 * (Length * Width + Length * Height + Width * Height),2);
            return Area;
        }

        public override double CalculateVolume()// calculates the volume of the box and rounds it to two
            //decimal places
        {
            Volume = Math.Round(Length * Width * Height,2);
            return Volume;
        }

        public override string ToString()
        {
            return $"Box\t\t3D\t\t {Length}x{Width}x{Height} \t\t\t {CalculateArea()}\t\t {CalculateVolume()}\n";
        }
    }
}
