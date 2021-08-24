using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.7, 20.3, 5.5};
            var grades = new List<double>() {12.7, 20.3, 5.5};
            grades.Add(21.5);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count; 
            Console.WriteLine($"A média é {result}");
            
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
