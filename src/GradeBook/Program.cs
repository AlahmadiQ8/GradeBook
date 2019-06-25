using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            // var book = new InMemoryBook("My Grades");
            var book = new DiskBook("My Grades");
            book.Gradeadded += OnGradeAdded;
            book.Gradeadded += OnGradeAdded;
            EterGrades(book);

            var result = book.GetStatistics();
            System.Console.WriteLine($"The Average is {result.Average}");
            System.Console.WriteLine($"The Minimum is {result.Min}");
            System.Console.WriteLine($"The Highest is {result.Max}");
            System.Console.WriteLine($"The letter grade is {result.Letter}");
        }

        private static void EterGrades(IBook book)
        {
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
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        public static void OnGradeAdded(object sender, EventArgs e) {
            System.Console.WriteLine("OMG");
        }
    }
}

