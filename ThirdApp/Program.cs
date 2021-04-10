using System;

namespace ThirdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("3d-figures realization started");

                Box bigBox = new Box(10);
                var p1 = new Cylinder(2, 4);
                var p2 = new Pyramid(100, 4);
                var p3 = new Ball(5);

                Console.WriteLine("Firstly, we have our Box, tht we gonna try to fill up.");
                Console.WriteLine("  It have the height of {0} and the volume of {1:0.###}", bigBox.H, bigBox.Volume());

                Console.WriteLine("Next step - we nedd a few others shapes, that we gonna drop into our Box");               
                Console.WriteLine("  Cylinder with radius {0}, height {1} and volume {2:0.###}", p1.R, p1.H, p1.Volume());                
                Console.WriteLine("  Pyramid with base square {0}, height {1} and volume {2:0.###}", p2.S, p2.H, p2.Volume());                
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
