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
                Console.WriteLine("Arg {0}: {1}", i, args[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(", ", myArgs));

            sayHello();

            Console.ReadLine();
        }

        private static void sayHello()
        {
            string name = "";
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
