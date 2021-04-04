using System;
using System.Collections.Generic;
using MyFirstApp;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            try
            {
                while (true)
                {
                    Console.WriteLine("You can choose:" +
                        "\n1)Calculation of triangle's perimeter" +
                        "\n2)Vector realization" +
                        "\n3)3d-figures realization");
                    int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {
                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        case 3:
                            Task3();
                            break;
                        default:
                            Console.WriteLine("Choose from 1, 2 or 3");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Task1()
        {
            Point p1 = new Point("First", 0, 0);
            Point p2 = new Point("Second", 0, 2);
            Point p3 = new Point("Third", 3, 0);
            Point p4 = new Point("Fourth", 3, 4);
            Point p5 = new Point("Fifth", 5, 4);

            Polygon triangle = new Polygon(p1, p2, p3);
            Polygon rectangle = new Polygon(p1, p2, p4, p3);
            Polygon pentagon = new Polygon(p1, p2, p4, p5, p3);
            Console.WriteLine("Triangle's perimeter: {0:0.###}", triangle.Perimeter());
            Console.WriteLine("Rectangles's perimeter: {0:0.###}", rectangle.Perimeter());
            Console.WriteLine("Pentagon's perimeter: {0:0.###}", pentagon.Perimeter());
        }
        static void Task2()
        {
            Vector v1 = new Vector(1, 2, 3);
            Console.WriteLine("First vector: x={0} y={1} z={2} length={3:0.###}", v1.X, v1.Y, v1.Z, v1.Length());
            Vector v2 = new Vector(0, 4, 5);
            Console.WriteLine("First vector: x={0} y={1} z={2} length={3:0.###}", v2.X, v2.Y, v2.Z, v2.Length());
            Console.WriteLine("Scalar of those vectors = {0:0.###}", Vector.Scalar(v1, v2));
            Vector v3 = Vector.Multiplication(v1, v2);
            Console.WriteLine("Multiplication of those vectors will result in vector: x={0:0.###} y={1:0.###} z={2:0.###}", v3.X, v3.Y, v3.Z);
            Vector v4 = Vector.Add(v1, v2);
            Console.WriteLine("Addition result in vector: x={0:0.###} y={1:0.###} z={2:0.###}", v4.X, v4.Y, v4.Z);
            Vector v5 = Vector.Subsract(v1, v2);
            Console.WriteLine("And substraction in vector: x={0:0.###} y={1:0.###} z={2:0.###}", v5.X, v5.Y, v5.Z);
            Console.WriteLine("Finally, the angle between those vector is {0:0.###}", Vector.Cos(v1, v2));
        }
        static void Task3()
        {
            Console.WriteLine("Firstly, we have our Box, tht we gonna try to fill up.");
            Box bigBox = new Box(10);
            Console.WriteLine("  It have the height of {0} and the volume of {1:0.###}", bigBox.H, bigBox.Volume());
            Console.WriteLine("Next step - we nedd a few others shapes, that we gonna drop into our Box");
            var p1 = new Cylinder(2, 4);
            Console.WriteLine("  Cylinder with radius {0}, height {1} and volume {2:0.###}", p1.R, p1.H, p1.Volume());
            var p2 = new Pyramid(100, 4);
            Console.WriteLine("  Pyramid with base square {0}, height {1} and volume {2:0.###}", p2.S, p2.H, p2.Volume());
            var p3 = new Ball(5);
            Console.WriteLine("  And ball with radius {0} and volume {1:0.###}", p3.R, p3.Volume());
            Console.WriteLine("Now lets fill our box, first we try to put cylinder");
            bigBox.Add(p1);
            Console.WriteLine("Next figure to add will be pyramid");
            bigBox.Add(p2);
            Console.WriteLine("Finally we gonna add ball");
            bigBox.Add(p3);
            Console.WriteLine("And if we try to add another ball");
            bigBox.Add(p3);
            Console.WriteLine("And for the final showdown - lets empty the box only to put our box in the box(yep)");
            bigBox.Empty();
            bigBox.Add(bigBox);
        }
    }
    
}
