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
           

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q'  to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                     book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
                
            };

            var stats  = book.CalcResult();
            Console.WriteLine($"The average is:  {stats.Average:N1}");
            Console.WriteLine($"The Hightest geade {stats.High}");
            Console.WriteLine($"The lowest grade {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
          
           
        }
    }
    
}