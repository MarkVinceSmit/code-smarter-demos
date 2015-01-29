using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadEx
{
    class Program
    {
        private static int counter = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(  "Started main app");
            Thread t1 = new Thread(ThreadProcess);
            Thread t2 = new Thread(ThreadProcess);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Finished main app");

            Console.WriteLine(  "Counter = {0}", counter);

        }

        static void ThreadProcess()
        {
            Console.WriteLine("Started sub");
            for (int x = 0; x < 100000; x++)
            {
                Interlocked.Increment(ref counter);  // lea counter,a0 + move #1,d0 + add.l  d0,(a0)
            }
            Console.WriteLine("Finish sub");
        }
    }
}
