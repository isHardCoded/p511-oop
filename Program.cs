using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace p511_oop
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "John",
                Age = 30
            };

            string json = JsonSerializer.Serialize(person);
            Console.WriteLine(json);

            Person deserialized = JsonSerializer.Deserialize<Person>(json);
            
        }
    }
}
