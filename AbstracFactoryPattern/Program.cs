using System;
using AbstracFactoryPattern.ColorFiles;
using AbstracFactoryPattern.ShapeColorFactoryFiles;
using AbstracFactoryPattern.ShapeFiles;

namespace AbstracFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractShapeAndColorFactory factory = new ShapeAndColorFactory();

            ShapeFactory shapeFactory = factory.getShapeFactory();

            IShape triangle = shapeFactory.getShape("triangle");
            triangle.draw();

            IShape rectangle = shapeFactory.getShape("rectangle");
            rectangle.draw();

            IShape circle = shapeFactory.getShape("circle");
            circle.draw();

            ColorFactory colorFactory = factory.getColorFactory();

            IColor red = colorFactory.getColor("red");
            red.paint();

            IColor green = colorFactory.getColor("green");
            green.paint();

            IColor yellow = colorFactory.getColor("yellow");
            yellow.paint();
        }
    }

}

