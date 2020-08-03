using System;
namespace Week4Day2OOP
{
    public class Animal
    {
        public string _color; //encapsulation and obstruction

        public string Color
        {
            get { return _color; }
            set { _color = value; }//value is a keyword of whatever you are passing in.  A placeholder for a value
        }
        //public string Color { get; set; } //these are properties
        public string Type { get; set; } //these are properties
        public string Name { get; set; } //these are properties
        public int Size { get; set; } //these are properties
        //Accessors Private, Public, Protected, and

        protected int Age;

                     //perameter
       /* public Animal(string color, string type, string name, int size) //this is a constructor.  No return type
        {                                                       //default can be set if unknown.  Default would need to be at the end.

            //property
            Color = color;
            Type = type;
            Name = name;
            Size = size;
           //perameters in the constructor should be the same name 
        }*/

        //Class members can be fields
    }
}
