using System;
namespace BridgePattern
{
    abstract class Vehicle
    {
        protected Workshop workshop1;
        protected Workshop workshop2;

        public Vehicle(Workshop workshop1, Workshop workshop2)
        {
            this.workshop1 = workshop1;
            this.workshop2 = workshop2;
        }

        public abstract void manufacture();
    }

    class Car: Vehicle
    {
        public Car(Workshop workshop1, Workshop workshop2): base(workshop1, workshop2)
        {
            
        }

        public override void manufacture()
        {
            this.workshop1.work();
            this.workshop2.work();
        }
    }

    class Bike : Vehicle
    {
        public Bike(Workshop workshop1, Workshop workshop2) : base(workshop1, workshop2)
        {

        }

        public override void manufacture()
        {
            this.workshop1.work();
            this.workshop2.work();
        }
    }
}

