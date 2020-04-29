using System;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cron1, cron2;

            cron1 = new Stopwatch();
            cron2 = new Stopwatch();

            cron1.Start();
            Thread.Sleep(1000);

            cron2.Start();
            Thread.Sleep(1000);

            cron1.Stop();
            cron2.Stop();

            Console.WriteLine($"Tempo cron1 = {cron1.ElapsedMilliseconds}");
            Console.WriteLine($"Tempo cron1 = {cron2.ElapsedMilliseconds}");
        }
    }
}
