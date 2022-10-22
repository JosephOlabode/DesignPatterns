using System;
namespace AbstracFactoryPattern.ShapeFiles
{
    class ShapeFactory
    {
        public IShape getShape(string type)
        {
            if (type.ToLower() == "rectangle")
                return new Rectangle();
            else if (type.ToLower() == "triangle")
                return new Triangle();
            else
                return new Circle();
        }
    }
}

