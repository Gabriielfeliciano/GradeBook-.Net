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
            book.ShowStatistics();
        }
    }
}
