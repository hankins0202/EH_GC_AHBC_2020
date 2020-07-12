using System;

namespace EH_GC_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("Enter Length:");
            var length = Console.ReadLine();
            Console.WriteLine("Enter Width:");
            var Width = Console.ReadLine();

            //Perimeter
            int perimeter = 2*(Convert.ToInt32(length)) + 2 * (Convert.ToInt32(Width));

            //Area
            //int area = Convert.ToInt32(length * Width);

            //Output
            Console.WriteLine("Perimeter:" + perimeter);
            //Console.WriteLine("Area:" + area);
            Console.WriteLine("Continue?(y/n)");

            string userChoice = Console.ReadLine();


            /*do
            {
                //Perimeter
                int perimeter = Convert.ToInt32(2 * length + 2 * Width);
                //Area
                int area = Convert.ToInt32(length * Width);
                //Output
                Console.WriteLine("Perimeter:" + perimeter);
                Console.WriteLine("Area:" + area);
                Console.WriteLine("Continue?(y/n)");
                string userchoice = Console.ReadLine();
               
            } while (userchoice = y);*/
         

        }
    }
}
