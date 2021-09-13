using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Gabriel's Grade Book");
            book.AddGrade(9.1);
            book.AddGrade(13.4);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"A média é {stats.Average}");
            Console.WriteLine($"A menor nota é {stats.Low}");
            Console.WriteLine($"A maior nota é {stats.High}");
        }
    }
}
