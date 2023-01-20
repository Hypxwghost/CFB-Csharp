using System;

namespace A002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}