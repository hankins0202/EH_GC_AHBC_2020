using System;

namespace Week3Day2Review //Assessment one review should be named MockAssessment1a, be sure to read all build specs prior to starting
{
    class Program
    {
        public static void Main(string[] args)
        {
            var something = IsTheSame(6, 8);
            var somethingelse = Subtract(10.3, 1.3); //use to debug or for assessment purposes debug using writeline
            var somethingmore = FindBuildingType(68); //assigning and initializing the method allows the return to output
            Console.Write(something);
            Console.Write(somethingelse);
            Console.Write(somethingmore);

            

            

            //Console.WriteLine(IsTheSame(6,8));
            //Console.WriteLine(Subtract(10.3,1.3));
        }
        //num1 - num2


        public static bool IsTheSame(int numberOne, int numberTwo) //1
        {
            //if (numberOne == numberTwo)//1a
            //{
            //    return true; //1a
            //}
            //return false; //1a

            return numberOne == numberTwo; //bool allows to evaluate and return as true or false
        }
        static double Subtract(double num1, double num2)
        {
            return num2 - num1;

        }

        static string FindBuildingType(int num1)
        {
            if(num1 >= 4 && num1 <= 10)
            {
                return "This is an office building!";
            }
            else if (num1 >= 50)
            {
                return "This is a super skyscrapper!";
            }
            else if (num1 >= 11 && num1 <= 49)
            {
                return "This is a skyscrapper!";
            }
            else if (num1 <= 3 && num1 >=0)
            {
                return "This is a house.";
            }
            //else
            //{
            //    return "something";
            //} 
            else if (num1 < 0) //added by Cory as a bonus
            {
                return "underground bunker";
            }
            return "Something";
        }
    }
}
