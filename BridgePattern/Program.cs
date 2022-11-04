using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manufacturing a Car");
            Vehicle car = new Car(new Produce(), new Assemble());
            car.manufacture();

            Console.WriteLine("Manufacturing a Bike");
            Vehicle bike = new Bike(new Produce(), new Assemble());
            bike.manufacture();
        }
    }
}

