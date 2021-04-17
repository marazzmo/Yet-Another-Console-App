using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ping ping = new Ping();
                Pong pong = new Pong();
                ping.message += pong.Play;
                pong.message += ping.Play;

                ping.Play();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
