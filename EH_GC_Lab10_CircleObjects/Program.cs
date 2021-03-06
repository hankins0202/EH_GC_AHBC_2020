﻿using System;
using System.Collections.Generic;

namespace EH_GC_Lab10_CircleObjects
{
    class Program
    {

        private static bool UserContinueSelection { get; set; } = true;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            List<double> CircleTotal = new List<double>();

            while (UserContinueSelection == true)
            {
                try
                {
                    Console.WriteLine("Enter radius: ");
                    double userInput = double.Parse(Console.ReadLine());

                    Circle circle = new Circle(userInput);
                    Validator validator = new Validator(1);
                    validator.CalculateFormattedArea();
                    validator.CalculateFormattedCircumference();

                    CircleTotal.Add(userInput);
                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                    Console.WriteLine($"Area:          {circle.CalculateFormattedArea()}");
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Oh No! Invalid entry. Would you like to try again?(y/n)");
                }
                UserContinue();

            }
            int TotalCircles = CircleTotal.Count;
            Console.WriteLine($"Goodbye. You created {TotalCircles} circle objects.");
            return;
        }
        private static void UserContinue()
        {
            Console.WriteLine("Continue?(y/n)");
            var userDesire = Console.ReadLine();


            if (userDesire.Contains("Y",StringComparison.InvariantCultureIgnoreCase))
            {
                UserContinueSelection = true;
            }
            else
            {
                UserContinueSelection = false;
            }
        }
    }
}
