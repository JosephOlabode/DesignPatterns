using System;
namespace AbstracFactoryPattern.ColorFiles
{
    class Red : IColor
    {
        public void paint()
        {
            Console.WriteLine("Painting it all Red");
        }
    }
}

