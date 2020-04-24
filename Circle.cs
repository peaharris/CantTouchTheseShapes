using System;
namespace Lab
{
    public class Circle
    {
        //F I E L D S
        private double radius;   //private instance variable radius

        //C O N S T R U C T O R S

        public Circle()  //Constructor without parameters defaults radius to 1.0, No-Arg Constructor
            : this(1.0) // calling another constructor
        {
        }

        public Circle(double radius) //1-Arg Constructor//shadowing demo
        {
            this.SetRadius(radius);
        }

        // M E T H O D S
        public double GetArea()  //Returns the area of a circle
        {
            return Math.PI * radius * radius;
        } // end GetArea( )

        public double GetCircumference()  //Returns the circumference of a circle
        {
            return 2.0 * Math.PI * radius;
        } // end GetCircumference( )

        public double GetRadius() //A "Getter" Method (gives a copy of the radius variable)
        {
            return radius;
        }

        public void SetRadius(double radius) //A "Setter" method returns nothing
        {
            if (radius > 0.0)
            {
                this.radius = radius;
            }
            else
            {
                Console.WriteLine("Radius must be greater than zero");
            }
        }// end of SetRadius( )
    } // end class Circle
}