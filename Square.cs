using System;
namespace Lab
{
    public class Square
    {
        //F I E L D S
        private double side = 1.0;  // Private is great encapsultion, default set to 1.0

        //C O N S T R U C T O R S

        public Square()  //Default Constructor
        {
        }

        public Square(double side) //2-Arg Constructor
        {
            SetSide(side);
        }

        //M E T H O D S

        public double GetArea()  //Returns Area
        {
            return side * side;
        }

        public double GetPerimeter()  //Returns Perimeter
        {
            return 4 * (side);
        }

        public double GetSide()   //Returns Side value
        {
            return side;
        }

        public void SetSide(double side)  //Sets Side value
        {
            if (side > 0)
            {
                this.side = side;
            }
        }
    }
}
