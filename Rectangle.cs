using System;
namespace Lab
{
    public class Rectangle  // Entity
    {
        //F I E L D S
        private double length = 1.0;  // Private is great encapsultion, default set to 1.0
        private double width = 1.0;   //private instance, default set to 1.0

        //C O N S T R U C T O R S

        public Rectangle ()  //Default Constructor
        {
        }

        public Rectangle (double length, double width) //2-Arg Constructor
        {
            SetDimensions(length, width);
        }

        //M E T H O D S

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength (double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth (double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        }

        public (double l, double w) GetDimensions()
        {
            return (length, width);
        }

        public void SetDimensions (double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        }
    }
}
