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
            List<Passport> passports = new List<Passport>();

            passports.Add(new Passport("John", "Doe", 1, 1));
            passports.Add(new Passport("Bob", "Doe", 2, 2));
            passports.Add(new Passport("Tom", "Doe", 3, 3));

            foreach (Passport passport in passports)
            {
                Console.WriteLine(passport.Print());
            }
        }
    }
}
