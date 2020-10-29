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
            bool boolFromString = bool.Parse("true");
            int intFromString = int.Parse("100");

            DateTime myDate = new DateTime(2005, 9, 17);

            Console.WriteLine("Day of week: {0}", myDate.DayOfWeek);

            Console.WriteLine("Six months laster: {0}", myDate.AddMonths(6));

            TimeSpan lunchTime = new TimeSpan(1, 0, 0);
            lunchTime = lunchTime.Add(new TimeSpan(0, 30, 0));

            Console.WriteLine("Lunch Time: {0}", lunchTime);

        }
    }
}
