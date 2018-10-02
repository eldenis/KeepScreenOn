using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepScreenOn
{
    internal class Program
    {
        /// <summary>
        /// Represents the SHIFT key being pressed
        /// </summary>
        private const string ShiftString = "+()";

        /// <summary>
        /// The number of seconds to wait between each of the simulated key strokes
        /// </summary>
        private static readonly TimeSpan TimeToSleep = TimeSpan.FromSeconds(45);

        private static void Main(string[] args)
        {
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        Thread.Sleep(TimeToSleep);
                        SendKeys.SendWait(ShiftString);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Oops.. There was an error: {ex.Message}");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            });

            Console.WriteLine("By the power vested in me by Grayskull, this PC's screen won't ever fade.");
            Console.ReadKey();
        }
    }
}
