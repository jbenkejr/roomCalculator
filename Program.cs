using System;

namespace Day_1___Lab_1_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            String doOver;

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!! ");
            Console.WriteLine("");

            do
            {
                //prompts user
                Console.Write("Enter Length: ");
                //user input
                String roomLength = Console.ReadLine();
                //prompts user
                Console.Write("Enter Width ");
                //user input
                String roomWidth = Console.ReadLine();
                //prompts user
                Console.Write("Enter Height ");
                //user input
                String roomHeight = Console.ReadLine();

                //convert strings to double
                double length = double.Parse(roomLength);
                double width = double.Parse(roomWidth);
                double height = double.Parse(roomHeight);

                //formulas
                double area = length * width;
                double perimeter = length + length + width + width;
                double volume = length * height * width;

                //output

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("Volume: {0}", volume);

                Console.WriteLine("");
                Console.Write("Continue? (y/n)");
                doOver = Console.ReadLine();

            } while (doOver.Equals("Y") || doOver.Equals("y"));

        }
    }
}
