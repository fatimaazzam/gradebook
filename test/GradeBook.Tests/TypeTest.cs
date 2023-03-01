using System;
using System.Diagnostics;
using Xunit;
namespace GradeBook.Tests;

public class TypeTest
{
    [Fact]
    public void Test1()
    {
        var book1 = GetBook("Book1");
        var book2 = GetBook("Book2");

        Assert.Equal("Book1", book1.Name);
        Assert.Equal("Book2", book2.Name);
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}