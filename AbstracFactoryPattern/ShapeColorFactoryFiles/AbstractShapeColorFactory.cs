using System;
using AbstracFactoryPattern.ColorFiles;
using AbstracFactoryPattern.ShapeFiles;

namespace AbstracFactoryPattern.ShapeColorFactoryFiles
{
    interface AbstractShapeAndColorFactory
    {
        public ShapeFactory getShapeFactory();
        public ColorFactory getColorFactory();
    }
}

