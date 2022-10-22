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
            AbstractShapeAndColorFactory factory = new ShapeAndColorFactory();

            ShapeFactory shapeFactory = factory.getShapeFactory();

            Shape triangle = shapeFactory.getShape("triangle");
            triangle.draw();

            Shape rectangle = shapeFactory.getShape("rectangle");
            rectangle.draw();

            Shape circle = shapeFactory.getShape("circle");
            circle.draw();

            ColorFactory colorFactory = factory.getColorFactory();

            Color red = colorFactory.getColor("red");
            red.paint();

            Color green = colorFactory.getColor("green");
            green.paint();

            Color yellow = colorFactory.getColor("yellow");
            yellow.paint();
        }
    }

}

