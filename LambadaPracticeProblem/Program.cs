namespace LambadaPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Lambda Expression!!!\n");

            List<Student> students = new List<Student>();
            StudentDataManegement.AddStudentData(students);
            StudentDataManegement.RetrieveBetweenRange(students);
        }
    }
    
    
}