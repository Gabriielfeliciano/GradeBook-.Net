using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(9.1);

            var grades = new List<double>() {12.7, 20.3, 5.5};
            grades.Add(21.5);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count; 
            Console.WriteLine($"A média é {result}");
            
        }
    }
}
