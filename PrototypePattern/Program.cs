using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel(30, 20);
            Car bmw = new BMW("BMW1", 2019, wheel);

            Car car1 = bmw.shallowClone();
            car1.name = "BMW copy";
            Console.WriteLine("Information from Shallow Copy");
            Console.WriteLine(car1.name);
            Console.WriteLine(car1.model);
            Console.WriteLine(car1.wheel.size);
            Console.WriteLine(car1.wheel.thickness);
            Console.WriteLine("");

            Car car2 = bmw.deepClone();
            Console.WriteLine("Information from Deep Copy");
            Console.WriteLine(car2.name);
            Console.WriteLine(car2.model);
            Console.WriteLine(car2.wheel.size);
            Console.WriteLine(car2.wheel.thickness);
        }
    }
}


interface ICar
{
    Car shallowClone();
    Car deepClone();
}
class Wheel
{
    public int size;
    public int thickness;

    public Wheel(int size, int thickness)
    {
        this.size = size;
        this.thickness = thickness;
    }
}

abstract class Car: ICar
{
    public string name;
    public int model;
    public Wheel wheel;

    public abstract Car deepClone();
    public abstract Car shallowClone();
}

class BMW : Car
{
    public BMW(string name, int model, Wheel wheel)
    {
        this.name = name;
        this.model = model;
        this.wheel = wheel;
    }

    public override Car deepClone()
    {
        Car car = (Car)this.MemberwiseClone();
        car.name = name;
        car.wheel = new Wheel(this.wheel.size, this.wheel.thickness);
        return car;
    }

    public override Car shallowClone()
    {
        return (Car) this.MemberwiseClone();
    }
}

class Honder : Car
{
    public Honder(string name, int model, Wheel wheel)
    {
        this.name = name;
        this.model = model;
        this.wheel = wheel;
    }
    public override Car deepClone()
    {
        Car car = (Car)this.MemberwiseClone();
        car.name = name;
        car.wheel = new Wheel(this.wheel.size, this.wheel.thickness);
        return car;
    }

    public override Car shallowClone()
    {
        return (Car)this.MemberwiseClone();
    }
}



