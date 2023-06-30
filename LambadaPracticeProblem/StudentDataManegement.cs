using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaPracticeProblem
{
   public class StudentDataManegement
    {
        public static void AddStudentData(List<Student> studentList)
        {
            studentList.Add(new Student(1, "Pot", "9999900000", "Bangalore", 25));
            studentList.Add(new Student(2, "Tom", "9638527410", "Mangalore", 15));
            studentList.Add(new Student(3, "Carl", "8527419630", "Delhi", 11));
            studentList.Add(new Student(4, "Peat", "8525643212", "Delhi", 12));
            studentList.Add(new Student(5, "Sam", "8000000000", "Shimla", 18));
            studentList.Add(new Student(6, "Rae", "8574195218", "Lucknow", 15));
            studentList.Add(new Student(7, "Jack", "8741741741", "Kochi", 20));
            studentList.Add(new Student(8, "Snow", "8700000000", "Kanpur", 17));
            studentList.Add(new Student(9, "John", "8700001234", "Agra", 19));
            studentList.Add(new Student(10, "Bean", "8700001234", "Dehradun", 20));
        }
        public static void DisplayStudentData(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Student with ID is: {student.Id} ,Name: {student.Name} ,PhoneNumber: {student.PhoneNumber} ,Address: {student.Address} ,Age: {student.Age}");
            }
        }
        public static void RetrieveBetweenRange(List<Student> studentList)
        {
            foreach (Student student in studentList.FindAll(x => x.Age >= 12 && x.Age <= 18))
            {
                Console.WriteLine($"Student with ID is: {student.Id} ,Name: {student.Name} ,PhoneNumber: {student.PhoneNumber} ,Address: {student.Address} ,Age: {student.Age}");
            }
        }
    }
}
