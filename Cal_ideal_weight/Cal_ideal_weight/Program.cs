using System;

namespace Cal_ideal_weight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "", gender = "", Ex = "";
            int height = 0, weight = 0;
            while (true)
            {

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Please fill in your Gender ");
                    Console.Write("For Male type 'M' and for female type 'F': ");
                    gender = Console.ReadLine();
                    if (gender != "M" && gender != "F")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter 'M' for Male or 'F' for Female");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please enter your Name: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                    }
                    else if (name.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name is too short. Please enter a valid name.");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Please enter your Height in cm: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Height cannot be empty. Please enter a valid height.");
                        continue;
                    }

                    if (!int.TryParse(input.Trim(), out height))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid number. Please enter a numeric height in cm.");
                        continue;
                    }

                    if (height <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Height must be greater than zero. Please enter a valid height.");
                        continue;
                    }

                    break;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                if (gender == "M")
                {
                    weight = height - 100;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hello Mr. " + name + ", your ideal weight is: " + weight + " kg");
                }
                else if (gender == "F")
                {
                    weight = height - 110;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hello Ms. " + name + ", your ideal weight is: " + weight + " kg");
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Press 'E' key to exit...");
                Ex = Console.ReadLine();
                if (Ex == "E")
                {
                    break;
                }
            }
        }
    }
}
