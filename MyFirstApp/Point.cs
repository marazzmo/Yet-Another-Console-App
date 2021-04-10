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
}
