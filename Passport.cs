using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Passport
    {
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        protected int _series { get; set; }
        protected int _number { get; set; }
        public Passport(string firstName, string lastName, int series, int number)
        {
            _firstName = firstName;
            _lastName = lastName;
            _series = series;
            _number = number;
        }
        public virtual string Print()
        {
            return $"Name: {_firstName} {_lastName}, Series & Number {_series} {_number} ";
        }
    }

    class ForeignPassport : Passport
    {
        private string _visa { get; set; }
        private int _foreignNumber { get; set; }
        public ForeignPassport(string firstName, string lastName, int series, int number, string visa, int foreignNumber) :
            base(firstName, lastName, series, number)
        {
            _visa = visa;
            _foreignNumber = foreignNumber;
        }
        public override string Print()
        {
            return base.Print() + $"ForeignNumber: {_foreignNumber} Visa: {_visa}"; ;
        }
    }
}
