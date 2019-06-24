using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("My Grades");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Enter a grade or 'q' to quit");
                }
            }

            var result = book.GetStatistics();
            System.Console.WriteLine($"The Average is {result.Average}");
            System.Console.WriteLine($"The Minimum is {result.Min}");
            System.Console.WriteLine($"The Highest is {result.Max}");
            System.Console.WriteLine($"The letter grade is {result.Letter}");
        }
    }
}

