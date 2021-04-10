using System;
using NUnit.Framework;
using ThirdApp;

namespace ThirdAppTests
{
    class ShapesTests
    {
        readonly Box box = new Box(10);
        readonly Ball b = new Ball(3);
        readonly Cylinder c = new Cylinder(2, 4);
        readonly Pyramid p = new Pyramid(10, 5);

        [Test]
        public void BoxVolumeTest()
        {
            Assert.AreEqual(box.Volume(), 1000, 0.005);
        }

        [Test]
        public void BallVolumeTest()
        {
            Assert.AreEqual(b.Volume(), 113.097, 0.005);
        }

        [Test]
        public void CylinderVolumeTest()
        {
            Assert.AreEqual(c.Volume(), 50.265, 0.005);
        }

        [Test]
        public void PyramidVolumeTest()
        {
            Assert.AreEqual(p.Volume(), 16, 0.005);
        }

        [Test]
        public void AdditionTest()
        {
            box.Add(box);

            Assert.IsFalse(box.Add(box));
        }
    }
}
