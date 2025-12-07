using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Aspirant : Student
    {
        private string Work {  get; set; }

        public Aspirant(string name, 
            string surname, 
            string group, 
            string work) : base(name, surname, group) {

            Work = work;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Work: {Work}");
        }
    }
}
