using System;

namespace Lab2_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Input the length of the Classroom in ft");

                double length = Double.Parse(Console.ReadLine());

                Console.WriteLine("Input the width of the Classroom in ft");

                double width = Double.Parse(Console.ReadLine());

                Console.WriteLine("Input the Height of the Classroom in ft");

                double height = Double.Parse(Console.ReadLine());

                double area = width * length;

                double perimeter = 2 * width + 2 * length;

                double paint = 0.2 * 1 * perimeter;

                double tiles = 0.2 * area;

                double volume = length * width * height;

                Console.WriteLine("The area of the room is " + area + " ft^2");

                Console.WriteLine("The perimeter of the room is " + perimeter + " ft");

                Console.WriteLine("The room will require " + paint + " cans of paint");

                Console.WriteLine("as well as " + tiles + " tiles of carpet");

                Console.WriteLine("Do you need to run another room y/n");

                string response = Console.ReadLine();

                if (response != "y")
                    i++;
            }

        }
    }
}
