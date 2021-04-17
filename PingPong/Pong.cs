using System;

namespace PingPong
{
    class Pong
    {
        Random rnd = new Random();
        public delegate void Game();
        public event Game message;

        public void Play()
        {
            int roll = rnd.Next(1, 20);
            Console.WriteLine($"Pong получил Ping ({roll})");
            if(roll >= 5)
            {
                if (message != null)
                    message();
            }
            else
            {
                Console.WriteLine($"Pong промахнулся! Победил Ping");
            }
        }
    }
}
