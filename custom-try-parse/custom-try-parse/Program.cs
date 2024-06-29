using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Create an int and try convert any string to an int 
             *  Notice the error, write a try...catch handler around it
             *  Catch the error and output the error message
             *  Without changing the current code
             *  
             *  Why is this a bad situation and how can we know if it's been
             *  converted?
             *  
             *  Create a custom try parse function 
             *  Find the real function and copy/return type/params
             *  Read the toolkit it gives you, to give you ideas on what to do
            */

            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine($"Yey " + result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }

            Console.ReadLine();

        }

        static bool TryParse(string input, out int result)
        {
            result = - 1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}