using System;
namespace Week4Day2OOP
{
    public abstract class Automobile //abstract is a keyword
    {
      protected abstract string Model { get; set; }
      public abstract string Make { get; set; }

      public abstract void Build();

    }
}
