// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("fatima");
            book.AddGrade(90.1);
            book.AddGrade(97.1);
            book.AddGrade(98.1);
            book.CalcResult();
          
           
        }
    }
    
}