using System;
namespace AbstracFactoryPattern.ShapeFiles
{
    class Triangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }
}

