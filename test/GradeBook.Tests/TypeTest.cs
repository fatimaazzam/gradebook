using System;
using System.Diagnostics;
using Xunit;
namespace GradeBook.Tests;


public class TypeTest
{
    [Fact]
    public void StringBehaveLikeValueType()
    {
        string name = "Fatima";
        var upper = MakeUppercase(name);
        Assert.Equal("FATIMA", upper);
    }

    private string MakeUppercase(string parameter)
    {
        return parameter.ToUpper();

    }

    

    [Fact]
    public void Test2()
    {
        var x = GetInt();
        SetInt(ref x);
        Assert.Equal(42, x);
    }

    private void SetInt(ref int x)
    {
        
        x = 42;
    }
    private int GetInt()
    {
       return 3;
    }
    public void TestName()
    {
        // Given
    
        // When
    
        // Then
    }


    [Fact]
    public void CSharpCanPassByRef()
    {
        // Given
            var book1 = GetBook("Book1");
            GetBookSetName(out book1, "New Name");
        // When
    
        // Then
        Assert.Equal("New Name", book1.Name);
    }

    private void GetBookSetName(out Book book, string name)
    {
        book = new Book(name);
        book.Name = name;
    }


    [Fact]
    public void Test1()
    {
        // Given
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");
        // When
    
        // Then
        Assert.Equal("Book1", book1.Name);
    }

    private void GetBookSetName(Book book, string name)
    {
        book = new Book(name);
        book.Name = name;
    }



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