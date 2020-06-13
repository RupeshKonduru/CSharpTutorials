using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public class AsyncAwait
    {
        

        void DoAsTask()
        {
            WriteOutput("1 - Starting");
            var t = Task.Factory.StartNew<int>(DoSomethingThatTakesTime);
            WriteOutput("2 - Task started");
            t.Wait();
            WriteOutput("3 - Task completed with result: " + t.Result);
        }

        async Task DoAsAsync()
        {
            WriteOutput("1 - Starting");
            var t = Task.Factory.StartNew<int>(DoSomethingThatTakesTime);
            WriteOutput("2 - Task started");
            var result = await t;
            WriteOutput("3 - Task completed with result: " + result);
        }

        int DoSomethingThatTakesTime()
        {
            WriteOutput("A - Started something");
            Thread.Sleep(1000);
            WriteOutput("B - Completed something");
            return 123;
        }

        public void WriteOutput(string message)
        {
            Console.WriteLine("[{0}] {1}", Thread.CurrentThread.ManagedThreadId, message);
        }
        static void Main()
        {
            AsyncAwait asv = new AsyncAwait();
            asv.WriteOutput("Program Begin");
            // DoAsTask();
            asv.DoAsAsync();
            asv.WriteOutput("Program End");
            Console.ReadLine();
        }
    }
}
