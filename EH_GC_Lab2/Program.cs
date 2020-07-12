using System;

namespace EH_GC_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length:");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                double Width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Height:");
                double Height = Convert.ToDouble(Console.ReadLine());

                //Perimeter
                int perimeter = 2 * (Convert.ToInt32(length)) + 2 * (Convert.ToInt32(Width));

                //Area
                int area = (Convert.ToInt32(length) * Convert.ToInt32(Width));

                //Volume
                int volume = (Convert.ToInt32(length) * Convert.ToInt32(Width) * Convert.ToInt32(Height));

                //Output
                Console.WriteLine("Perimeter:" + perimeter);
                Console.WriteLine("Area:" + area);
                Console.WriteLine("Volume:" + volume);

                //Continue

                string y = "y";

                bool userChoice = true;

                while (userChoice)

                {
                    Console.WriteLine("Continue?(y/n)");
                    string answer = Console.ReadLine();
                    if (answer == y)
                    {
                        Console.WriteLine("Enter Length:");
                        double length2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Width:");
                        double Width2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Height:");
                        double Height2 = Convert.ToDouble(Console.ReadLine());

                        //Perimeter
                        int perimeter2 = 2 * (Convert.ToInt32(length2)) + 2 * (Convert.ToInt32(Width2));

                        //Area
                        int area2 = (Convert.ToInt32(length2) * Convert.ToInt32(Width2));

                        //Volume
                        int volume2 = (Convert.ToInt32(length2) * Convert.ToInt32(Width2) * Convert.ToInt32(Height2));

                        //Output
                        Console.WriteLine("Perimeter:" + perimeter2);
                        Console.WriteLine("Area:" + area2);
                        Console.WriteLine("Volume:" + volume2);

                    }
                    else
                    {
                        Console.WriteLine("Thank you!");
                        userChoice = false;
                    }
                }
            }
        }
    }
}
