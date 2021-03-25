using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!\nType something: ");
            string s = Console.ReadLine();
            Console.WriteLine("Oho, you can type something like " + s + "! Impressive!");
            Console.ReadKey();
        }
    }
}
