using System;
using System.Diagnostics;
using Xunit;
namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        // arrange
        var book = new Book("Fatima");
        book.AddGrade(98.1);
        book.AddGrade(97.1);
        book.AddGrade(985.1);

        //act
        var result = book.CalcResult();

        //assert
        Debug.Assert.Equal(96.7, result.average);
        
    }
}