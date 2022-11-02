using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Normal Turkey....");
            ITurkey turkey = new Turkey();
            turkey.fly();
            turkey.gooble();

            Console.WriteLine("\n\nNormal Duck....");
            IDuck duck = new Duck();
            duck.fly();
            duck.quack();

            Console.WriteLine("\n\nAdapted Turkey....");
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);
            turkeyAdapter.fly();
            turkeyAdapter.quack();


        }
    }


    interface ITurkey
    {
        void gooble();
        void fly();
    }

    interface IDuck
    {
        void quack();
        void fly();
    }

    class Turkey : ITurkey
    {
        public void fly()
        {
            Console.WriteLine("Flying short distance");
        }

        public void gooble()
        {
            Console.WriteLine("Gooble Gooble");
        }
    }

    class Duck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("Flying all the way");
        }

        public void quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }


    class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void fly()
        {
            // if the turkey can fly short distances 5 times it catches up with the normal duck, just giving the turkey the abilities of a duck :)
            for (int i = 0; i < 5; i++)
            {
                this.turkey.fly();
            }
        }

        public void quack()
        {
            this.turkey.gooble();
        }
    }

}

