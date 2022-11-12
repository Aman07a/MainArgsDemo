using System;

namespace MainArgsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The args array cannot be null. So, it's safe to access the Length property without null checking.
            // So we check the length of the array if it's zero it means no arguments were provided to the application.
            if(args.Length == 0) {
                Console.WriteLine("This is a smart app that uses args. Please provide arguments next time.");
                // Pause the application so it doesn't quite after printing our error message
                Console.ReadKey();
                // Quit the application entirelysince we can't proceed further since, the arguments are empty.
                return;
            }

            Console.WriteLine("Hello " + args[0]);
            Console.ReadKey();
        }
    }
}
