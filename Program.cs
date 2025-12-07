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
            Student student = new Student("John", "Doe", "P511");
            student.Print();

            Aspirant aspirant = new Aspirant("Bob", "Doe", "P413", "Work 1");
            aspirant.Print();
        }
    }
}
