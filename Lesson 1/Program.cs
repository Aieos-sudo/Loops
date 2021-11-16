using System;


namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //printToConsole();
            //Console.WriteLine("First Argument is: " + args[0]);
            //Console.WriteLine("Second Argument is: " + args[0]);

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Argument " + i + " is " + args[i]);
            //}
            bool flag = false;
            int i = 0;
            while (flag == true)
            {
                Console.WriteLine("Argument " + i + " is " + args[i]);
                ++i;
            }
            //int i = 0;
            //bool flag = false;
            //do
            //{
            //    Console.WriteLine("Argument " + i + " is " + args[i]);
            //    i++;
            //} while (flag == true);
        }

        static void printToConsole()
        {
            Console.WriteLine("in printToConsole()");



        }
    }
}
