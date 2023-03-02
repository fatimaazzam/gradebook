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
            var stats  = book.CalcResult();
            Console.WriteLine($"The average is:  {stats.Average:N1}");
            Console.WriteLine($"The Hightest geade {stats.High}");
            Console.WriteLine($"The lowest grade {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
          
           
        }
    }
    
}