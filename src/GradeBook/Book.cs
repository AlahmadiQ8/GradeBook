using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string Name;
        private List<double> grades = new List<double>();

        public Book(string name)
        {
            Name = name;
        }

        public void AddLEtterGrade(char letter) {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                this.grades.Add(grade);
            } else {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {
            char letter;
            switch (GetAverage())
            {
                case var d when d >= 90.0:
                    letter = 'A';
                    break;
                case var d when d >= 80.0:
                    letter = 'B';
                    break;
                case var d when d >= 70.0:
                    letter = 'C';
                    break;
                case var d when d >= 60.0:
                    letter = 'D';
                    break;
                default:
                    letter = 'F';
                    break;
            }

            var result = new Statistics(this.GetMin(), this.GetMax(), this.GetAverage(), letter);
            return result;
        }

        private double GetSum()
        {
            var result = 0.0;
            foreach (var item in this.grades)
            {
                result += item;
            }
            return result;
        }

        private double GetAverage()
        {
            return this.GetSum() / this.grades.Count;
        }

        private double GetMin()
        {
            var min = double.MaxValue;
            foreach (var item in this.grades)
            {
                min = Math.Min(item, min);
            }
            return min;
        }

        private double GetMax()
        {
            var max = double.MinValue;
            foreach (var item in this.grades)
            {
                max = Math.Max(item, max);
            }
            return max;
        }
    }
}