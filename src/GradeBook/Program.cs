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
            book.AddGrade(89.1);
            


            var grades = new List<double>() {12.5, 13, 6.6, 9};
            grades.Add(56.1);
            
            var result = 0.0;
           
            foreach(var number in grades)
            {
                result += number;
            }

            result /=  grades.Count;
            Console.WriteLine($"The average is {result:N1}");
               
        }
    }
    
}