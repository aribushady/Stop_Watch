using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Stop_Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStopwatch watch = new CustomStopwatch();
            ConsoleKeyInfo info;

            Console.WriteLine($"Press Enter to start the Stop Watch");
            Console.WriteLine($"Press Backspace to stop the Stop Watch");
            Console.WriteLine($"Press ESC to exit program");

            try
            {
                while (true)
                {
                    info = Console.ReadKey(true);
                    if (info.Key == ConsoleKey.Enter)
                    {
                        watch.Start();
                        Console.WriteLine($"Started...");
                    }
                    else if (info.Key == ConsoleKey.Backspace)
                    {
                        watch.Stop();
                        Console.WriteLine($"Stopped...");
                        Console.WriteLine($"Duration: {watch.DurationTime()}");
                    }
                    else if (info.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
