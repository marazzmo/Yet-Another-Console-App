using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.MinValue;
            int secondNum = int.MinValue;
            try
            {
                Console.Write("Hello World!\nOkay than, how large this massive will be? ");
                int n = int.Parse(Console.ReadLine());
                int[] mass = new int[n];
                Console.WriteLine("Now enter the numbers of your massive one by one: ");
                for (int i = 0; i < n; i++)
                {
                    int tmp = int.Parse(Console.ReadLine());
                    if (tmp >= firstNum) { secondNum = firstNum; firstNum = tmp; }
                    else if (tmp >= secondNum) { secondNum = tmp; }
                    mass[i] = tmp;
                }

                Console.Write("That's your massive:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" {0}", mass[i]);
                }

                Console.WriteLine("\nAnd that's the second higher number: {0}", secondNum);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                {
                    Console.WriteLine("Nuh-uh, that's not a number. Try again.");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
