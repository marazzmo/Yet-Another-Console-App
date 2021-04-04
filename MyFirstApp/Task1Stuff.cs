using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Point
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }
        public Point(string name, int x, int y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }
    }
    public class Polygon
    {
        List<Point> _points = new List<Point>();

        public Polygon(Point p1, Point p2, Point p3)
        {
            _points.Add(p1);
            _points.Add(p2);
            _points.Add(p3);
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4)
        {
            _points.Add(p1);
            _points.Add(p2);
            _points.Add(p3);
            _points.Add(p4);
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            _points.Add(p1);
            _points.Add(p2);
            _points.Add(p3);
            _points.Add(p4);
            _points.Add(p5);
        }

        public double Perimeter()
        {
            var points = _points;
            double result = 0;
            int pointsCount = points.Count - 1;
            for(int i = 0; i <= pointsCount - 1; i++)
            {
                double d = Math.Sqrt((points[i + 1].X - points[i].X) * (points[i + 1].X - points[i].X) + (points[i + 1].Y - points[i].Y) * (points[i + 1].Y - points[i].Y));
                result = result + d;
            }
            result = result + Math.Sqrt((points[pointsCount].X - points[0].X) * (points[pointsCount].X - points[0].X) + (points[pointsCount].Y - points[0].Y) * (points[pointsCount].Y - points[0].Y));
            return result;
        }
    }
}
