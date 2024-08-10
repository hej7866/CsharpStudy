using System;


namespace _001_HelloWorld
{
    class Program
    {
        //static void Main()
        //{
        //    Console.WriteLine("Hello World");
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (args.Length > 0)
            {
                Console.WriteLine("arg: " + args[0]);
            }
        }
    }
}
