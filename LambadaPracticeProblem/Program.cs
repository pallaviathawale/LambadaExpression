namespace LambadaPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
        {
            new Student { Id = 1, Name = "Pallavi", PhoneNumber = "7218533707", Address = "akola", Age = 25 },
            new Student { Id = 2, Name = "Rashmi", PhoneNumber = "97522358", Address = "amaravati", Age = 26 },
            new Student { Id = 3, Name = "Nisha", PhoneNumber = "98635174", Address = "mumbai", Age = 25 }
        };

            Console.WriteLine("Student Details:");
            studentList.ForEach(student =>
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine();
            });
        }
    }
    
}