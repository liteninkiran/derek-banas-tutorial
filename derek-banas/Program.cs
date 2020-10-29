using System;

namespace derek_banas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i = 0; i <args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.ReadLine();
        }
    }
}
