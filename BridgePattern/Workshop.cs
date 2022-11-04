using System;
namespace BridgePattern
{
    public abstract class Workshop
    {
        public abstract void work();
    }


    class Produce : Workshop
    {
        public override void work()
        {
            Console.WriteLine("Produce");
        }
    }

    class Assemble : Workshop
    {
        public override void work()
        {
            Console.WriteLine("And Assemble");
        }
    }
}

