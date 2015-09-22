using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRepl
{
    class Program
    {
        static bool isRunning = true;
        static void Main(string[] args)
        {
            Console.CancelKeyPress += delegate(object sender, ConsoleCancelEventArgs e) { e.Cancel = true; Program.isRunning = false; };

            while (isRunning)
            {
                if (isRunning) new ReplCore().Feed(new OperationLine(Console.ReadLine().Trim()));
                else break;
            }
        }


    }
}
