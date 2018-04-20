using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "start")
                {
                    stopwatch.Start();
                }
                else if (command.ToLower() == "stop")
                {
                    Console.WriteLine(stopwatch.Stop());
                }
            }
        }
    }
}
