using System;
namespace AbstracFactoryPattern.ShapeFiles
{
    class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}

