using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{

    class User
    {
        public string name;
        public string surname;
        public int age;
        public string city;

        public User(string name, string surname, int age, string city)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.city = city;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}, City: {city}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();            
        }
    }
}
