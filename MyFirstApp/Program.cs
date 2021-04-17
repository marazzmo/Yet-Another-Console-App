using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CounterTask c = new CounterTask();
                CounterHandler1 h1 = new CounterHandler1();
                CounterHandler2 h2 = new CounterHandler2();

                c.reachedCount += h1.Message;
                c.reachedCount += h2.Message;

                c.CounterStart();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
