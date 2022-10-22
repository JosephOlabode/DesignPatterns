using System;
namespace AbstracFactoryPattern.ColorFiles
{
    class ColorFactory
    {
        public IColor getColor(string type)
        {
            if (type.ToLower() == "red")
                return new Red();
            else if (type.ToLower() == "green")
                return new Green();
            else
                return new Yellow();
        }
    }
}

