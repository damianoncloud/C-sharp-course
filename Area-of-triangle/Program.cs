namespace Exercise
{
    class Program
    {
        /*
         * Ask user for weight and height, store them 
         * Create function to calculate the area
         * Function should calculate the area using: (width * height) / 2
         * Call in main and print out the area of the triangle
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert triangle width: ");
            float width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please insert triangle height: ");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Triangle area is: ");
            Console.WriteLine(TriangleArea(width, height));

            Console.ReadLine();
        }

        static float TriangleArea(float width, float height)
        {
            float result = (width * height) / 2;

            return result;
        }
    }
}

