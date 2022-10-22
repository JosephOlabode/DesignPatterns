using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape rectangle = ShapeFactory.getShape("rectangle");
            rectangle.draw();

            IShape triangle = ShapeFactory.getShape("triangle");
            triangle.draw();

            IShape circle = ShapeFactory.getShape("circle");
            circle.draw();
        }
    }

    interface IShape
    {
        void draw();
    }

    class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    class Triangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }

    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class ShapeFactory
    {
        public static IShape getShape(string type)
        {
            if (type.ToLower() == "rectangle")
                return new Rectangle();
            else if (type.ToLower() == "triangle")
                return new Triangle();
            else
                return new Circle();
        }
    }
}

