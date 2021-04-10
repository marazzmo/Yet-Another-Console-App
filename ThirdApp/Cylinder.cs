using System;

namespace ThirdApp
{
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
}
