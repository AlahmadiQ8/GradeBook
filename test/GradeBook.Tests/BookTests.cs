using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculcatesStatistics()
        {
            var book = new InMemoryBook("My Grades");
            book.AddGrade(1);
            book.AddGrade(2);
            book.AddGrade(3);
            book.AddGrade(2);
            book.AddGrade(1);
            var result = book.GetStatistics();

            Assert.Equal(result.Min, 1);
            Assert.Equal(result.Max, 3);
            Assert.Equal(result.Average, 1.8);

        }
    }
}
