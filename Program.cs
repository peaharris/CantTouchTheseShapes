using System;

namespace Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //R E C T A N G L E                        
            Rectangle r1 = new Rectangle(2, 3);  //Reference type (Complex), setting dimensions to (2, 3)
            r1.SetDimensions(-5, 10);    //trying to set dimensions to (-5, 10) however, negative numbers are not allowed, wont take -5 value
            double area1 = r1.GetArea(); //setting the area equal to area1
            Console.WriteLine(area1);  //printing off the area

            double perimeter1 = r1.GetPerimeter();  //settting the perimeter to perimeter1
            Console.WriteLine(perimeter1);  //printing off the perimeter
            (double l2, double w2) = r1.GetDimensions();   //setting the dimensions to l2 and w2

            //C I R C L E
            Circle c1 = new Circle(5.0); // class Circle in Circle.cs, created a new variable, setting radius to 5.0
            c1.SetRadius(1.0);  //changing the radius to 1.0
            c1.SetRadius(-1.0); //trying to change radius to negative number, however, Circle does not accept negative numbers, keeps 1.0 value

            double circumference = c1.GetCircumference();  //setting the circumference value to circumference
            double area = c1.GetArea();  //setting the area value to area
            Console.WriteLine(circumference);  //printing out the circumference
            Console.WriteLine(area);  //printing out hte area

            //S Q U A R E
            Square s1 = new Square(3.0);  //creating a new square with side value 3.0
            s1.SetSide(4.0);  //changing the side value to 4.0
            s1.GetSide();  //getting what the s1 square side value is
            double area2 = s1.GetArea();  //getting the area and setting it equal to area2
            double perimeter = s1.GetPerimeter();  //getting the perimeter and setting it equal to perimeter

            //T R I A N G L E
            Triangle t1 = new Triangle();  //creating a new triangle, using default values
            t1.SetDimensions(-1.0, 1.0, 1.0);  //trying to set values to (-1.0, 1.0, 1.0), however, triangle does not allow for negative values

            Console.WriteLine(t1.GetAllSides());  //printing all the sides of the triangle t1
            Console.WriteLine(t1.GetPerimeter());  //printing the perimeter of triangle t1
            Console.WriteLine(t1.GetArea());  //printing the area of triangle t1

            //This is how you would call it if the method was non static
            //SafeConsoleInput sci = new SafeConsoleInput();
            //double userInput = sci.GetSafeDouble("Number Please: ");
            //Console.WriteLine(userInput);

            //This is how you would call a method if it is static

            double userInput1 = SafeConsoleInput.GetSafeDouble("Number Please: ");  //calling a static method, setting it equal to userInput1
            Console.WriteLine("- - - - - - ");
            double userInput2 = SafeConsoleInput.GetSafeDouble("Number Please: "); //calling a static method, setting it equal to userInput2
            Console.WriteLine(userInput1); //printing off userInput1
            Console.WriteLine(userInput2); //printing off userInput2

            //SafeConsoleInput sci = new SafeConsoleInput(); //This is now useless because it is a static method now. 


        }
    }
}
