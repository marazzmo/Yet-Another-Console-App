using System;

namespace ThirdApp
{
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
