namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "",gender = "";
            int height = 0, weight = 0;

            Console.WriteLine("Please fill in your Gender ");
            Console.Write("For Male type 'M' and for female type 'F': ");
            gender = Console.ReadLine();
            Console.Write("Please enter your Name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your Height in cm: ");
            height = Convert.ToInt32(Console.ReadLine());
            if (gender == "M")
            {
                weight = height - 100;
                Console.WriteLine("Hello Mr. " + name + ", your ideal weight is: " + weight + " kg");
            }
            else { 
                weight = height - 110;
                Console.WriteLine("Hello Ms. " + name + ", your ideal weight is: " + weight + " kg");

            }
        }
    }
}
