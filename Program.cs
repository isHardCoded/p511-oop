using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace p511_oop
{

 
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.AppendAllText("data.txt", "\nHello World!");
                string text = File.ReadAllText("data.txt");
                Console.WriteLine(text);
            } catch(UnauthorizedAccessException ex) {
                Console.WriteLine("Нет прав на открытие файл");
            }
            foreach (Figure f in figures)
            {
                Console.WriteLine(f.GetArea());
            }
        }
    }
}
