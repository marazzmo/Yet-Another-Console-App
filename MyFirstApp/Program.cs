using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Calculation of triangle's perimeter:");

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}
