using System;
namespace Week4Day2OOP
{
    public class Wagon : Automobile
    {
        public Wagon()
        {
        }
                //override is signaling that it is overriding the properties of the base class
        public override string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Build()
        {
            throw new NotImplementedException();
        }
    }
}
