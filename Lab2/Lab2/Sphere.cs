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
/// creates a Sphere class which inherits the property Radius from Circle class
/// </summary>
    class Sphere:Circle
    {
        private double radius;

        public Sphere(string type,double radius)
            : base(radius,type)
        {
            Radius = radius;
        }

        public override double CalculateArea()// calculates the surface area of the sphere and rounds it to
            //two decimal places
        {
            Area = Math.Round(4 * PI * Math.Pow(Radius, 2),2);
            return Area;
        }

        public override double CalculateVolume()// calculates the volume of the sphere and rounds it to two
            //decimal places
        {
            Volume = Math.Round(1.33 * PI * Math.Pow(Radius, 3),2);
            return Volume;
        }

        public override string ToString()
        {
            return $"Sphere\t\t3D\t\t {Radius}\t\t\t{CalculateArea()}\t\t {CalculateVolume()} \n";
        }
    }
}
