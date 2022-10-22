using System;
using AbstracFactoryPattern.ColorFiles;
using AbstracFactoryPattern.ShapeFiles;

namespace AbstracFactoryPattern.ShapeColorFactoryFiles
{
    class ShapeAndColorFactory : AbstractShapeAndColorFactory
    {
        public ColorFactory getColorFactory()
        {
            return new ColorFactory();
        }

        public ShapeFactory getShapeFactory()
        {
            return new ShapeFactory();
        }
    }
}

