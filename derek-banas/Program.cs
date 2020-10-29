using System;

namespace derek_banas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            for(int i = 0; i <args.Length; i++)
            {
                //Console.WriteLine("Arg {0}: {1}", i, args[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();

            //Console.WriteLine(string.Join(", ", myArgs));

            //sayHello();

            dataTypes();

            Console.ReadLine();
        }

        private static void sayHello()
        {
            string name = "";
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        private static void dataTypes()
        {
            decimal decPi  = 3.1415926535897932384626433832M;
            decimal decNum = 0.0000000000000000000000000018M;

            double dblPi  = 3.141592653589793;
            double dblNum = 0.0000000000000004;

            Console.WriteLine("Smallest Long: {0}", long.MinValue);
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("");

            Console.WriteLine("DECIMAL Pi + Num: {0}", decPi + decNum);
            Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);
            Console.WriteLine("Biggest Decimal: {0}", decimal.MaxValue);
            Console.WriteLine("");

            Console.WriteLine("DOUBLE Pi + Num: {0}", dblPi + dblNum);
            Console.WriteLine("Smallest Double: {0}", double.MinValue);
            Console.WriteLine("Biggest Double: {0}", double.MaxValue);
            Console.WriteLine("");

        }
    }
}
