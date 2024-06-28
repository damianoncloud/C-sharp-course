namespace Exercise
{
    class Program
    {

        /*

            Create a for loop from 1 to X (15)
            3 and 5 = FizzBuzz
            3 = Fizz
            5 = Buzz
            else = number  

        */


        static void Main(string[] args)
        {
            Console.WriteLine("Please insert an integer limit to print numbers: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            bool divisibleByThree = false;
            bool divisibleByFive = false;

            for (int i = 1; i <= userNumber; i++)
            {
                divisibleByThree = i % 3 == 0;
                divisibleByFive = i % 5 == 0;

                if (divisibleByThree && divisibleByFive)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (divisibleByThree)
                {
                    Console.WriteLine("Fizz");
                } else if (divisibleByFive)
                {
                    Console.WriteLine("Buzz");
                }else {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}