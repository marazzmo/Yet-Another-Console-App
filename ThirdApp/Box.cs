using System;

namespace ThirdApp
{
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
}
