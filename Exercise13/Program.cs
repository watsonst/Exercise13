using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";

            do
            {

                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());


                for (int i = input; i >= 0; i--)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine("\nWould you like to continue? y/n");
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                }

            }
            while (answer == "y");
        }
    }
}