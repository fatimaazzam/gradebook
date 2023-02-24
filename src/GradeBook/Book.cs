namespace GradeBook
{
    public class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void CalcResult(){
            
            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            
            foreach(var number in grades)
            {
                
                lowestGrade = Math.Min(number, lowestGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /=  grades.Count;
            Console.WriteLine($"The average is {result:N1}");
            Console.WriteLine($"The Hightest geade {highGrade}");
            Console.WriteLine($"The lowest grade {lowestGrade}");
        }

        

        private List<double> grades;
        private string name;

        

        

    }

}