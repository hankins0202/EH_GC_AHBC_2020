using System;
namespace Week4Day2OOP
{
    public class Dog : Animal
    {
        //Dog is child of Animal class. Animal is the parent class
        // needs to satisfy the attributes of the Animal class
        //Dog class access to Animal age property because it is derived from the Animal classs

        
        public void Bark ()
        {

            Console.WriteLine("woof woof.");
        }
    }
}
