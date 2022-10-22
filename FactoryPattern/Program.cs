using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = ShapeFactory.getShape("rectangle");
            rectangle.draw();

            Shape triangle = ShapeFactory.getShape("triangle");
            triangle.draw();

            Shape circle = ShapeFactory.getShape("circle");
            circle.draw();
        }
    }

    interface Shape
    {
        void draw();
    }

    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    class Triangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }

    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class ShapeFactory
    {
        public static Shape getShape(string type)
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

