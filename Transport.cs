using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Transport
    {
        protected double speed;
        protected double costPerKm;
        protected int passengerCapacity;
        protected double cargoCapacity;

        protected Transport(double speed, double costPerKm, int passengerCapacity, double cargoCapacity)
        {
            this.speed = speed;
            this.costPerKm = costPerKm;
            this.passengerCapacity = passengerCapacity;
            this.cargoCapacity = cargoCapacity;
        }

        public abstract double CalculateTime(double distance);
        public abstract double CalculateCost(double distance, int passengers, double cargo);
    }
    class Car : Transport
    {
        public Car() : base(80, 15, 4, 0.5) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }

        public override double CalculateCost(double distance, int passengers, double cargo)
        {
            return (distance * costPerKm) + (passengers *  100) + (cargo + 500);
        }
    }
    class Bicycle : Transport
    {
        public Bicycle() : base(15, 2, 1, 0) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }

        public override double CalculateCost(double distance, int passengers, double cargo)
        {
            return (distance * costPerKm) + (passengers * 100) + (cargo + 500);
        }
    }
    class Cart : Transport
    {
        public Cart() : base(10, 5, 2, 0.2) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }

        public override double CalculateCost(double distance, int passengers, double cargo)
        {
            return (distance * costPerKm) + (passengers * 100) + (cargo + 500);
        }
    }

}
