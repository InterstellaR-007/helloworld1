using helloworld.Services;
using System;
//using helloworld.Services;

namespace helloworld
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            addition cal = new addition();
            int c = cal.AddNumber(4, 5);

            Console.WriteLine("Hello World......");
            //string xyz = Console.ReadLine();
            Console.WriteLine(c);

        }
    }
}
