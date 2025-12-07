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
            List<Transport> transports = new List<Transport>()
            {
                new Car(),
                new Bicycle(),
                new Cart()
            };

            double distance = 100;
            int passengers = 2;
            double cargo = 0.3;

            foreach (Transport transport in transports)
            {
                Console.WriteLine($"Время: {transport.CalculateTime(distance)}");
                Console.WriteLine($"Стоимость: {transport.CalculateCost(distance, passengers, cargo)}");
            }
        }
    }
}
