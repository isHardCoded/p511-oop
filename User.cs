using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class User
    {
        private string name;
        private int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name {
            get
            {
                return name;          
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    
        public void Print()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
        }
    }
}
