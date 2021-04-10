using System;
using NUnit.Framework;
using MyFirstApp;

namespace MyFirstAppTests
{
    public class PerimeterTests
    {
        [Test]
        public void TrianglePerimeterTest()
        {
            Point p1 = new Point("1", 0, 0);
            Point p2 = new Point("2", 1, 1);
            Point p3 = new Point("3", 0, 1);
            Polygon t = new Polygon(p1, p2, p3);
            Assert.AreEqual(t.Perimeter(), 3.414, 0.005);
        }
    }
}
