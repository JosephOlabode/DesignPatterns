using System;
namespace AbstracFactoryPattern.ShapeFiles
{
    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}

