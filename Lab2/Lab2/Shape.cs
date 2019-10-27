/*
 * @author Sumit Aggarwal - 000793607
 * I certify that all work done in the assignment is my own work and that I have not copied it
 * from any other source. I also certify that I have not allowed anyone else to copy my code.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public abstract class Shape
    {
        private double area;
        private double volume;
        public string Type { get; } //The type of shape
        public static int Count { get; private set; } //
        protected const double PI = 3.141592653589793; //Constant value for pi
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Area)} must be >= 0");
                }
                area = value;
            }
        }

        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Volume)} must be > 0");
                }
                volume = value;
            }
        }

        //All this constructor does is increment the number of Shape instances
        public Shape(string type)
        {
            Type = type;
            Shape.Count++;
        }

        public abstract double CalculateArea(); //Calculate the Shape's area (surface area if 3-d)
        public abstract double CalculateVolume(); //Calculate the Shape's volume (if 3-d)

        //Retrieves the current number of Shape instances
    }
}
