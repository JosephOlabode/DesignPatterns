using System;
namespace AbstracFactoryPattern.ColorFiles
{
    class Yellow : IColor
    {
        public void paint()
        {
            Console.WriteLine("Painting it all Yellow");
        }
    }
}

