using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await DoSomethingAsync();
        }
        static async Task DoSomethingAsync()
        {
            int value = 13;


            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

            value *= 2;


            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

            Trace.WriteLine(value);
        }

    }
}
