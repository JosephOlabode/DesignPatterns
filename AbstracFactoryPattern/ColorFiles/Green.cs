using System;
namespace AbstracFactoryPattern.ColorFiles
{
    class Green : IColor
    {
        public void paint()
        {
            Console.WriteLine("Painting it all Green");
        }
    }
}

