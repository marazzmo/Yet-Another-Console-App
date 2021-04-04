using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public abstract class Shape
    {
        public abstract double Volume();
    }
    public class Box : Shape
    {
        public int H { get; }
        private double OccupiedVolume { get; set; } = 0;
        public Box(int h)
        {
            this.H = h;
        }
        public override double Volume()
        {
            return H * H * H;
        }
        public bool Add(Shape s)
        {
            if (OccupiedVolume + s.Volume() <= this.Volume())
            {
                OccupiedVolume = OccupiedVolume + s.Volume();
                Console.WriteLine("  Shape succesfully added. Space left: {0:0.###}", this.Volume() - OccupiedVolume);
                return true;
            }
            Console.WriteLine("  Nuh-uh, don't have enough space. Space left: {0:0.###}", this.Volume() - OccupiedVolume);
            return false;
        }
        public void Empty()
        {
            OccupiedVolume = 0;
        }
    }
    public class Cylinder : Shape
    {
        public int R { get; }
        public int H { get; }
        public Cylinder(int r, int h)
        {
            this.R = r;
            this.H = h;
        }
        public override double Volume()
        {
            return Math.PI * R * R * H;
        }
    }
    public class Pyramid : Shape
    {
        public int S { get; }
        public int H { get; }
        public Pyramid(int s, int h)
        {
            this.S = s;
            this.H = h;
        }
        public override double Volume()
        {
            return S * H / 3;
        }
    }
    public class Ball : Shape
    {
        public int R { get; }
        public Ball(int r)
        {
            this.R = r;
        }
        public override double Volume()
        {
            return 4 * Math.PI * R * R * R / 3;
        }
    }
}
