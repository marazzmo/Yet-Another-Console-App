using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(" Type your name: ");
            string s = Console.ReadLine();
            Console.WriteLine("Hello " + s);
            Console.Read();
            Console.Clear();
        }
    }
}
