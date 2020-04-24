using System;
namespace Lab
{
    public class Triangle
    {
        //F I E L D S
        private double a = 2.0;   //default set to 2.0
        private double b = 2.0;   //default set to 2.0
        private double c = 3.0;   //default set to 3.0

        //C O N S T R U C T O R S

        public Triangle()  // No-Arg Constructor
        {
        }

        public Triangle(double a, double b, double c) //3-Arg Constructor
        {
            SetDimensions(a, b, c);
        }

        // M E T H O D S
        public double GetArea()  // Get Area using Heron's Formula
        {
            double p = (a + b + c) / 2;
            double areaTri = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return areaTri;
        }

        public double GetPerimeter() //Get Perimeter
        {
            return a + b + c;
        }

        public double GetSideA()  //Get side A
        {
            return a; 
        }

        public void SetSideA(double a)  //Set side A if a > 0 
        {
            if (a > 0)
            {
                this.a = a;
            }
        }

        public double GetSideB() //Get Side B
        {
            return b;
        }

        public void SetSideB(double b)  //Set side B if a > 0 
        {
            if (b > 0)
            {
                this.b = b;
            }
        }

        public double GetSideC()  //Get side C
        {
            return c;
        }

        public void SetSideC(double c) //Set side c if c > 0
        {
            if (c > 0)
            {
                this.c = c;
            }
        }

        public (double a, double b, double c) GetAllSides()   //Get all sides
        {
            return (a, b, c);
        }

        public void SetDimensions(double a, double b, double c)   //Set all sides if true
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                SetSideA(a);
                SetSideB(b);
                SetSideC(c);
            }

        }// end of SetRadius( )
    } // end class Circle
}
