using System;
namespace Week4Day2OOP
{
    public class Sedan : Automobile//Sedan is the child class and Automobile is the parent class.
    {


        public override string Make { get; set; }
        protected override string Model { get; set; }
        public int Tires { get; set; }

        public Sedan (string make, string model)
        {
            Make = make;
            Model = model;
        }

        public override void Build()
        {
            var numberOfTires = CreateTires();
            Console.WriteLine($"I have built a sedan :{Make} and {Model} with tires: {Tires}");
        }


        //encapsolated.  Can only be seen in the Sedan class and can only be accessed through the sedan class.
        private int CreateTires()
        {
            return Tires + 1;
        }
    }
}
