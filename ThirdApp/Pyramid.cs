namespace ThirdApp
{
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
}
