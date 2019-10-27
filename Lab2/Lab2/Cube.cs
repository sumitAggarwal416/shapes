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
/// creates the Cube class which inherits the property Side from the Square class
/// </summary>
    class Cube:Square
    {
        public Cube(string type,double side)
            : base(type,side)
        {
            Side = side;
        }

        public override double CalculateArea()// calculates the surface area of the cube and rounds it to
            //two decimal places
        {
            Area =Math.Round( 6 * Math.Pow(Side, 2),2);
            return Area;
        }

        public override double CalculateVolume()// calculates the volume of the cube and rounds it to two
            // decimal places
        {
            Volume = Math.Round(Math.Pow(Side, 3),2);
            return Volume;
        }

        public override string ToString()
        {
            return $"Cube\t\t3D\t\t {Side}\t\t\t{CalculateArea()}\t\t {CalculateVolume()}\n";
        }
    }
}
