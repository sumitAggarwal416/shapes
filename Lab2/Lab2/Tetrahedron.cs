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
/// creates a class Tetrahedron that inherits from the class Triangle the property Edge
/// </summary>
    class Tetrahedron:Triangle
    {
        public Tetrahedron(string type, double edge,double height)
            : base(type,edge,height)
        {
            Edge = edge;
        }

        public override double CalculateArea()//calculates the surface area of the tetrahedron and rounds
            //the answer to two deciaml places
        {
            Area = Math.Round(Math.Sqrt(3) * Math.Pow(Edge, 2),2);
            return Area;
        }

        public override double CalculateVolume()//calculates the volume of the tetrahedron and rounds
                                                //the answer to two deciaml places
        {
            Volume = Math.Round(Math.Pow(Edge, 3) / (6 * Math.Sqrt(2)),2);
            return Volume;
        }

        public override string ToString()
        {
            return $"Tetrahedron\t3D\t\t{Edge}\t\t\t {CalculateArea()}\t\t{CalculateVolume()}\n";
        }
    }
}
