using System;
namespace Lab
{
    public class SafeConsoleInput
    {
        //F I E L D S

        private int fields;  //private instance variable

        //C O N S T R U C T O R S

        private SafeConsoleInput()  //constructor is private takes no input, nobody from the outside is allowed to call it
        {

        }

        //M E T H O D S
        public static double GetSafeDouble(string prompt)  //because it doesnt use any field variables than make it static
        {
            double result = 0.0;
            bool error = true;
            do
            {
                Console.WriteLine(prompt);

                try
                {
                    result = double.Parse(Console.ReadLine());
                    error = false;
                }
                catch (Exception e)
                {

                }
            } while (error == true);

            return result;
        }
    }
}
