using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public double AverageGrade {  get; set; }

        public Student(string name, int age, double averageGrade)
        {
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
        }

        public override string ToString()
        {
            return $"{Name};{Age};{AverageGrade}";
        }
    }

    public class StudentManager
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Студент успешно добавлен в список");
        }

        public void PrintAllStudents()
        {
            foreach (Student student in students)
            {
                if (!students.Any())
                {
                    Console.WriteLine("В списке нет студентов");
                    return;
                }

                Console.WriteLine(student.ToString());
            }
        }

        public void SaveToFile(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    foreach (Student student in students)
                    {
                        writer.WriteLine(student.ToString());
                    }
                }

                Console.WriteLine("Данные успешно записаны");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void LoadFromFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // 1. Очистить список Students
                    while ((line = reader.ReadLine()) != null)
                    {                  
                        // 2. Нужно разбить строку на массив - Split()

                        // "Apple, Banana, Watermelon".Split(", ")

                        // var parts = ["Apple", "Banana", "Watermelon"]

                        // 3. parts[0] parts[1] parts[2]

                        // 4. students.Add(new Student(parts[0], parts[1], parts[2]))
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
