using System;
using System.Threading.Tasks;

namespace Async_Main
{
    class Program
    {
        //before C# 7.1
        static void Main(string[] args)
        {
            Console.WriteLine("Before C# 7.1, To use async method");
            Console.WriteLine($"Main Method execution started at {System.DateTime.Now}");
            Task.Delay(2000).GetAwaiter().GetResult();
            Console.WriteLine($"Main Method execution ended at {System.DateTime.Now}");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }

    }
}
