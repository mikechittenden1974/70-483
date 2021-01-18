using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Working on the Main Thread...................");
            }
        }
    }
    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            // If we comment out the await Task.Run instructions and
            // just call LongRunningOperation(), everything happens
            // synchronously... 
            // Program counts to 49, then writes 'Doing stuff..."
            //
            // Task.Run starts a background thread
            // Await means this task must complete before the rest of this method is rn
            await Task.Run(() =>
            {
                CountToFifty();
            });

            // This code will not run until the CountToFifty call has completed
            Console.WriteLine("Counting to 50 completed...");
        }

        private static async Task<string> CountToFifty()
        {
            int counter;

            for (counter = 0; counter < 51; counter++)
            {
                Console.WriteLine("BG thread: " + counter);
            }

            return "Counter = " + counter;
        }
    }
}
