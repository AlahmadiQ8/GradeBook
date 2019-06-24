using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public readonly double Min;
        public readonly double Max;
        public readonly double Average;
        public readonly char Letter;

        public Statistics(double min, double max, double average, char letter)
        {
            Min = min;
            Max = max;
            Average = average;
            Letter = letter;
        }
    }
}