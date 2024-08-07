using System;
using SingletonPatternExample.Singleton;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current Directory: {AppDomain.CurrentDomain.BaseDirectory}");

            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger instances are the same.");
            }

            logger1.Log("Application started.");
            logger2.Log("Application running.");
            logger1.Log("Application finished.");
        }
    }
}
