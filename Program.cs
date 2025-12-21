using p511_oop;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_PATH = @"C:\Users\User\Desktop\data.txt";
            
            StudentManager studentManager = new StudentManager();

            studentManager.AddStudent(new Student("John", 20, 4.5));

            studentManager.PrintAllStudents();

            studentManager.SaveToFile(FILE_PATH);
            studentManager.LoadFromFile(FILE_PATH);

            // Реализация меню в с помощью конструкции switch()
        }
    }
}
