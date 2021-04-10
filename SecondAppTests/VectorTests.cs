using System;
using NUnit.Framework;
using SecondApp;

namespace SecondAppTests
{
    public class VectorTests
    {
        readonly Vector v1 = new Vector(1, 2, 3);
        readonly Vector v2 = new Vector(0, 4, 5);

        [Test]
        public void LengthTest()
        {
            Assert.AreEqual(v1.Length(), 3.742, 0.005);
        }

        [Test]
        public void ScalarTest()
        {
            Assert.AreEqual(Vector.Scalar(v1, v2), 23);
        }

        [Test]
        public void MultiplicationTest()
        {
            var va = Vector.Multiplication(v1, v2);
            var ve = new Vector(-2, -5, 4);

            Assert.AreEqual(ve.X, va.X);
            Assert.AreEqual(ve.Y, va.Y);
            Assert.AreEqual(ve.Z, va.Z);
        }

        [Test]
        public void AdditionTest()
        {
            var va = Vector.Add(v1, v2);
            var ve = new Vector(1, 6, 8);

            Assert.AreEqual(ve.X, va.X);
            Assert.AreEqual(ve.Y, va.Y);
            Assert.AreEqual(ve.Z, va.Z);
        }

        [Test]
        public void SubstractionTest()
        {
            var va = Vector.Subsract(v1, v2);
            var ve = new Vector(1, -2, -2);

            Assert.AreEqual(ve.X, va.X);
            Assert.AreEqual(ve.Y, va.Y);
            Assert.AreEqual(ve.Z, va.Z);
        }

        [Test]
        public void CosinusTest()
        {
            Assert.AreEqual(Vector.Cos(v1, v2), 0.96, 0.005);
        }
    }
}
