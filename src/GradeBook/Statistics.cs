using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        private List<double> grades;

        public Statistics()
        {
            grades = new List<double>();
        }

        public void Add(double grade) {
            grades.Add(grade);
        }

        private double Sum
        {
            get
            {
                var result = 0.0;
                foreach (var item in this.grades)
                {
                    result += item;
                }
                return result;
            }
        }

        public double Average => this.Sum / this.grades.Count;

        public double Min
        {
            get
            {
                var min = double.MaxValue;
                foreach (var item in this.grades)
                {
                    min = Math.Min(item, min);
                }
                return min;
            }
        }

        public double Max
        {
            get
            {
                var max = double.MinValue;
                foreach (var item in this.grades)
                {
                    max = Math.Max(item, max);
                }
                return max;
            }
        }

        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
    }
}