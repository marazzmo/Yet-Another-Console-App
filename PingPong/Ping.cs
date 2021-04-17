using System;

namespace PingPong
{
    class Ping
    {
        Random rnd = new Random();
        public delegate void Game();
        public event Game message;

        public void Play()
        {
            int roll = rnd.Next(1, 20);
            Console.WriteLine($"Ping получил Pong ({roll})");
            if (roll >= 5)
            {
                if (message != null)
                {
                    message();
                }
            }
            else
            {
                Console.WriteLine($"Ping промахнулся! Победил Pong");
            }
        }
    }
}
