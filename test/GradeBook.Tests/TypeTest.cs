using System;
using System.Diagnostics;
using Xunit;
namespace GradeBook.Tests;

public class TypeTest
{
    [Fact]
    public void CanSetnameFromReferenace()
    {
        // Given
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");
        // When
    
        // Then
        Assert.Equal("New Name", book1.Name);
    }

    private void SetName(Book book, string name)
    {
        book.Name = name;
    }


    [Fact]
    public void GetBookReturnDifferentObject()
    {
        var book1 = GetBook("Book1");
        var book2 = GetBook("Book2");

        Assert.Equal("Book1", book1.Name);
        Assert.Equal("Book2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReturnReferenceSameObject()
    {
        var book1 = GetBook("Book1");
        var book2 = book1;

        Assert.Same(book1, book2);
        Assert.True(object.ReferenceEquals(book1, book2));
    }


    Book GetBook(string name)
    {
        return new Book(name);
    }
}