using System;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Vector realization started");

                Vector v1 = new Vector(1, 2, 3);
                Vector v2 = new Vector(0, 4, 5);

                Console.WriteLine("First vector: x={0} y={1} z={2} length={3:0.###}", v1.X, v1.Y, v1.Z, v1.Length());
                Console.WriteLine("First vector: x={0} y={1} z={2} length={3:0.###}", v2.X, v2.Y, v2.Z, v2.Length());

                Console.WriteLine("Scalar of those vectors = {0:0.###}", Vector.Scalar(v1, v2));

                Vector v3 = Vector.Multiplication(v1, v2);
                Console.WriteLine("Multiplication of those vectors will result in vector: x={0:0.###} y={1:0.###} z={2:0.###}", v3.X, v3.Y, v3.Z);

                Vector v4 = Vector.Add(v1, v2);
                Console.WriteLine("Addition result in vector: x={0:0.###} y={1:0.###} z={2:0.###}", v4.X, v4.Y, v4.Z);

                Vector v5 = Vector.Subsract(v1, v2);
                Console.WriteLine("And substraction in vector: x={0:0.###} y={1:0.###} z={2:0.###}", v5.X, v5.Y, v5.Z);

                Console.WriteLine("Finally, the angle between those vector is {0:0.###}", Vector.Cos(v1, v2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
