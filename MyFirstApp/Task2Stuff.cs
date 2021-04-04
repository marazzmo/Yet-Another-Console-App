using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Vector
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static double Scalar(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        public static Vector Multiplication(Vector v1, Vector v2)
        {
            return new Vector(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }
        public static double Cos(Vector v1, Vector v2)
        {
            return Scalar(v1, v2) / (v1.Length() * v2.Length());
        }
        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector Subsract(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
    }
}
