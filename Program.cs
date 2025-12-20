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
            Person person = new Person("Tom", 25);
            ObjectToTxt save = new ObjectToTxt();
            
            save.SaveObject(person);         
        }
    }
}
