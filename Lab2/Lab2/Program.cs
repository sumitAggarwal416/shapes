/*
 * @author Sumit Aggarwal - 000793607
 * I certify that all work done in the assignment is my own work and that I have not copied it
 * from any other source. I also certify that I have not allowed anyone else to copy my code.
 */
using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        private static int option; // user's choice of the shape at a particular instinct
        /// <summary>
        /// The main method of the project
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();// array list of the shapes and all their instances
            Console.WriteLine("----------------------S H A P E S----------------------");
            bool isRunning = true; //loop control variable
            while (isRunning)
            {
                Console.WriteLine("Select your shape:\n" +
                    "1 - Square\n" +
                    "2 - Rectangle\n" +
                    "3 - Circle\n" +
                    "4 - Triangle\n" +
                    "5 - Ellipse\n" +
                    "6 - Sphere\n" +
                    "7 - Box\n" +
                    "8 - Cube\n" +
                    "9 - Cylinder\n" +
                    "10 - Tetrahedron\n" +
                    "0 - Exit\n");

                Console.WriteLine($"You have {Shape.Count} shape(s) as of this instance");
                Console.WriteLine("Type '11' to see all your shapes\n");

                option = int.Parse(Console.ReadLine()); 
                bool x = true;
                try
                {
                    switch (option) // iterating through the choices that user picks
                    {
                        case 0:
                            isRunning = false;
                            break;
                        case 1:
                            while (x) //to prompt the command until the user enters a valid value
                            {

                                Console.WriteLine("Please enter the side of your square");
                                double side = double.Parse(Console.ReadLine());// reads what the user typed
                                if (side > 0)
                                {
                                    Shape square = new Square("2D Shape - Square", side);
                                    // new instance of the Shape Square
                                    shapes.Add(square);// square is added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 2:
                            while (x)
                            {

                                Console.WriteLine("Please enter the length of your rectangle");
                                double length = double.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter the width of your rectangle");
                                double width = double.Parse(Console.ReadLine());
                                if (length > 0 && width > 0)
                                {
                                    Shape rectangle = new Rectangle("2D Shape - Rectangle", length,
                                        width); 
                                    // instance of Shape Rectangle
                                    shapes.Add(rectangle); //rectangle added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 3:
                            while (x)
                            {

                                Console.WriteLine("Please enter the radius of your circle");
                                double radius = double.Parse(Console.ReadLine());
                                if (radius > 0)
                                {
                                    Shape circle = new Circle(radius, "2D Shape - Circle");
                                    //instance of the Shape Circle
                                    shapes.Add(circle); //circle added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 4:
                            while (x)
                            {

                                Console.WriteLine("Please enter the edge of your triangle");
                                double edge = double.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter the height of your triangle");
                                double height = double.Parse(Console.ReadLine());
                                if (edge > 0 && height > 0)
                                {
                                    Shape triangle = new Triangle("2D Shape - Triangle", edge, height);
                                    //instance of the Shape Triangle
                                    shapes.Add(triangle);// triangle added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 5:
                            while (x)
                            {

                                Console.WriteLine("Please enter the first axis of your ellipse");
                                double r1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter the second axis of your ellipse");
                                double r2 = double.Parse(Console.ReadLine());
                                if (r1 == r2 && r2 != 0)
                                {
                                    Shape circle = new Circle(r1, "2D Shape - Circle");
                                    Console.WriteLine("Since both the axes are equal, therefore, it " +
                                        "is basically a circle");
                                    shapes.Add(circle);
                                    x = false;
                                }
                                if (r1 > 0 && r2 > 0)
                                {
                                    Shape ellipse = new Ellipse("2D Shape - Ellipse", r1, r2);
                                    //instance of the Shape Ellipse
                                    shapes.Add(ellipse);
                                    // ellipse added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 6:
                            while (x)
                            {
                                Console.WriteLine("Please enter the radius of your sphere");
                                double radius = double.Parse(Console.ReadLine());
                                if (radius > 0)
                                {
                                    Shape sphere = new Sphere("3D Shape - Sphere",radius);
                                    //instance of the Shape Sphere
                                    shapes.Add(sphere);
                                    //sphere added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }
                            }
                            break;
                        case 7:
                            while (x)
                            {

                                Console.WriteLine("Please enter the length of your box");
                                double length = double.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter the width of your box");
                                double width = double.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter the height of your box");
                                double height = double.Parse(Console.ReadLine());
                                if (length > 0 && width > 0 && height > 0)
                                {
                                    Shape box = new Box("3D Shape - Box", length, width, height);
                                    //instance of the Shape Box
                                    shapes.Add(box);
                                    //box added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 8:
                            while (x)
                            {

                                Console.WriteLine("Please enter the side of your cube");
                                double side = double.Parse(Console.ReadLine());
                                if (side > 0)
                                {
                                    Shape cube = new Cube("3D Shape - Cube", side);
                                    //instance of the Shape Cube
                                    shapes.Add(cube);
                                    // cube added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 9:
                            while (x)
                            {
                                Console.WriteLine("Please enter the radius of your cylinder");
                                double radius = double.Parse(Console.ReadLine());
                                Console.WriteLine("Please enter the height of your cylinder");
                                double height = double.Parse(Console.ReadLine());
                                if (radius > 0 && height > 0)
                                {
                                    Shape cylinder = new Cylinder("3D Shape - Cylinder", radius, height);
                                    //instance of the Shape Cylinder
                                    shapes.Add(cylinder);
                                    // cylinder added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }
                            }
                            break;
                        case 10:
                            while (x)
                            {

                                Console.WriteLine("Please enter the edge of your tetrahedron");
                                double edge = double.Parse(Console.ReadLine());
                                if (edge > 0 )
                                {
                                    Shape tetrahedron = new Tetrahedron("3D Shape - Tetrahedron",
                                        edge, edge);
                                    //instance of the Shape Tetrahedron
                                    shapes.Add(tetrahedron);
                                    //tetrahedron added to the array list
                                    x = false;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry\n");
                                }

                            }
                            break;
                        case 11:
                            Console.WriteLine("\nShape\t\tType\t\tDimensions\t\tArea\t\tVolume");
                            foreach (Shape s in shapes) //iterating through the array list and displaying all
                                Console.WriteLine(s);
                            break;
                        default:
                            Console.WriteLine("Invalid! Please try again");
                            break;                           
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Invalid Entry! " + ex.Message + " Please try again.\n");
                }
                
            }

        }
    }
}
