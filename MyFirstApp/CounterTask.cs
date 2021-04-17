using System;

namespace Counter
{
    public class CounterTask
    {
        public delegate void ReachedCountHandler();
        public event ReachedCountHandler reachedCount;

        public void CounterStart()
        {
            Console.WriteLine("Counter started");
            for(int i = 1; i <= 100; i++)
            {
                if(i == 75)
                {
                    reachedCount();
                }
            }
        }
    }
}
