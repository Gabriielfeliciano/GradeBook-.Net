using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[3];
            numbers[1] = 11.2;

            if(args.Length >0)
            {
            Console.WriteLine($"Hello {args[1]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
