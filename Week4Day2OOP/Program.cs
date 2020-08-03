using System;
using System.Collections.Generic;

namespace Week4Day2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Red", "Fred", "Tiger", 10);//created an object from a class
            //class ubstantiated calls to class and creates constructor
            //First "Animal" is the type, 
            /*animal.Color = "Red";
            animal.Name = "Fred";
            animal.Size = 10;
            animal.Type = "Tiger";*/
            var dog = new Dog();
            dog.Bark();
            dog.Color = "Blue";//dog class has access to 
            dog.Name = "Ellie";

            Automobile automobileNH = new Automobile("Chevy", "Malibu", 4); //not happy because of the abstract keyword.
            Automobile automobile = new Sedan("Chevy", "Malibu");  //Polymorphism.  Automobile is being instantiated using Sedan child class
            Automobile automobile1 = new Wagon();

            List<Wagon> wagons = new List<Wagon>();
            List<Automobile> automobiles = new List<Automobile>()
            {
                new Wagon(),
                new Sedan("Chevy", "Cruz")
            };

            foreach (var vehicle in automobiles)
            {
                Console.WriteLine(vehicle.Make);
            }





            Console.WriteLine(animal.Color);//Only prints color
        }
    }
}
