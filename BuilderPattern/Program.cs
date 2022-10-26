using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder vehicleBuilder = new Builder();

            IVehicle car = new Car();
            vehicleBuilder.construct(car);
            Vehicle createdCar = car.getVehicle();
            createdCar.show();

            IVehicle bike = new Bike();
            vehicleBuilder.construct(bike);
            Vehicle createdBike = bike.getVehicle();
            createdBike.show();

        }
    }

    interface IVehicle
    {
        public void buildBody();
        public void buildWheel();
        public void buildHeadLamp();
        public Vehicle getVehicle();
    }

    class Car : IVehicle
    {
        private readonly Vehicle vehicle = new Vehicle();

        public void buildBody()
        {
            vehicle.add( "Building car body");
        }

        public void buildHeadLamp()
        {
            vehicle.add( "Building 2 head lamps for the car");
        }

        public void buildWheel()
        {
            vehicle.add( "Building 4 wheels of the car");
        }

        public Vehicle getVehicle()
        {
            return vehicle;
        }
    }

    class Bike : IVehicle
    {
        private readonly Vehicle vehicle = new Vehicle();

        public void buildBody()
        {
            vehicle.add("Building the bike body");
        }

        public void buildHeadLamp()
        {
            vehicle.add("Building 1 head lamp for the bike");
        }

        public void buildWheel()
        {
            vehicle.add("Building 2 wheels of the bike");
        }

        public Vehicle getVehicle()
        {
            return vehicle;
        }
    }

    class Vehicle
    {
        private List<string> parts ;

        public Vehicle()
        {
            parts = new List<string>();
        }

        public void add(string part)
        {
            parts.Add(part);
        }

        public void show()
        {
            foreach(var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }

    interface IBuilder
    {
        public void construct(IVehicle vehicle);
    }

    class Builder : IBuilder
    {
        private IVehicle vehicle;
        public void construct(IVehicle myVehicle)
        {
            vehicle = myVehicle;
            vehicle.buildBody();
            vehicle.buildHeadLamp();
            vehicle.buildWheel();
            //vehicle.getVehicle();
        }
    }
}

