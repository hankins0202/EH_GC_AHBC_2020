using System;

namespace ROSHAMBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ROSHAMBO");
            Console.WriteLine("First player, choose your weapon of mass destruction. 0. Rock, 1. Paper, or 2. Scissors.");
            RPS input = (RPS)int.Parse(Console.ReadLine());
            Console.WriteLine("Second player, choose your weapon of mass destruction. 0. Rock, 1. Paper, or 2. Scissors.");
        }
    }
}
