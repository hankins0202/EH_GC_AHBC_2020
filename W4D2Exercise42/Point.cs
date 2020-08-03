using System;
namespace W4D2Exercise42
{
    public class Point
    {
        public string X { get; set; } // sets as 20 through constructor from user input. Saved to memory Same for Y. The getter is saying get me that value that was assigned

        public string Y { get; set; }

        public Point(string xPoint, string yPoint) //Contructor ctor shortcut
        {
            X = xPoint; //X = x Correct way to write this //these should be named one to one. 
            Y = yPoint; //Y = y  Best practices says this should be one to one.
        }

        

    }
}
