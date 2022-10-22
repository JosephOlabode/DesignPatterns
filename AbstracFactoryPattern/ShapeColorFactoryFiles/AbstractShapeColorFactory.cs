using System;
using AbstracFactoryPattern.ColorFiles;
using AbstracFactoryPattern.ShapeFiles;

namespace AbstracFactoryPattern.ShapeColorFactoryFiles
{
    interface IAbstractShapeAndColorFactory
    {
        public ShapeFactory getShapeFactory();
        public ColorFactory getColorFactory();
    }
}

