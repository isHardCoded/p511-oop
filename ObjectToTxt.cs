using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p511_oop
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
    internal class ObjectToTxt
    {
        public void SaveObject(Person person)
        {
            string filePath = @"C:\Users\User\Desktop\data.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(person.ToString());
            }
        }
    }
}
