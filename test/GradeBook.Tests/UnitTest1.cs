using System;
using System.Diagnostics;
using Xunit;
namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BookCalculateAverageGrade()
    {
        // arrange
        var book = new Book("Fatima");
        book.AddGrade(98.1);
        book.AddGrade(97.1);
        book.AddGrade(98.2);
        book.AddGrade(998.2);

        //act
        var result = book.CalcResult();

        //assert
       
        Assert.Equal(97.79,result.Average,1);
        Assert.Equal(98.2,result.High);
        Assert.Equal(97.1,result.Low);
        Assert.Equal('A',result.Letter);

    }
}