namespace GradeBook
{
    public class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics CalcResult(){
            
            
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            
            
            foreach(var number in grades)
            {
                
                result.Low = Math.Min(number, result.Low);
                result.High = Math.Max(number, result.High);
                result.Average += number;
            }

            result.Average /=  grades.Count;
            return result;
              }

        

        private List<double> grades;
        public string Name;

        

        

    }

}