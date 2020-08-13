using System;
using W5D3_Enums.Cars;
using W5D3_Enums.Enums;
using W5D3_Enums.Exercise5860;

namespace W5D3_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInputforShapes();
            //UserInputForAutomobiles();
            UserShuffleDeck();
        }

        private static void UserShuffleDeck()
        {
            Random random = new Random();
            Suit suitNum = (Suit)random.Next(4); //Casting. (suit) takes in the random number and converts it to the item assoicated with the number.
            Rank rankNum = (Rank)random.Next(12);

            Console.WriteLine($"Shuffling...You drew a {rankNum} of {suitNum}.");
        }

        private static void UserInputforShapes()
        {
            Console.WriteLine("What shape would like to use?");
            Console.WriteLine("Enter the sides of the shape");

            var userInput = Console.ReadLine();
            var didParse = Enum.TryParse(userInput, out NumberOfSides side);

            IShape shape; //creating a variable of type IShape
            //"shape is taking on many forms (circle, triangle, ect
            switch (side)
            {
                case NumberOfSides.Circle:
                    Console.WriteLine("You entered a Circle");
                    shape = new Circle(side);
                    break;
                case NumberOfSides.Triangle:
                    Console.WriteLine("You entered a Triangle");
                    break;
                case NumberOfSides.Rectangle:
                    Console.WriteLine("You entered a Rectangle");
                    break;
                case NumberOfSides.Hexagon:
                    shape = new Hexagon();
                    shape.NumberOfSides = side;
                    Console.WriteLine($"You entered a Hexagon {shape.NumberOfSides}");
                    break;
                default:
                    break;
            }
        }


        private static void UserInputForAutomobiles()
        {
            Console.WriteLine("What is your dream car?");
            var UserInput = Console.ReadLine();
            var isCarType = Enum.TryParse(UserInput, out CarType carType);

            IAutomobile automobile;

            switch(carType)
            {
                case CarType.SUV:
                    automobile = new SUV();
                    automobile.Mileage = 170000;
                    automobile.Type = carType;
                    automobile.VroomVroom();
                    break;
                case CarType.Rickshaw:
                    automobile = new Rickshaw();
                    automobile.Mileage = 5;
                    automobile.Type = carType;
                    automobile.VroomVroom();
                    break;
                case CarType.Sports:
                    automobile = new Sports
                    {
                        Mileage = 500,
                        Type = carType
                    };
                    automobile.VroomVroom();
                    break;
                default:
                    break;

            }
        }
    }
}
