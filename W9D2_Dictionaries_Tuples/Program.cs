using System;
//using System.Collections.Generic;


namespace W9D2_Dictionaries_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            //How we could potentionally store zipcode and sales tax for lookup/reference
            /*var dictionaryExample = new Dictioinary<int, decimal>()
            {
                { 48236, 0.06m },
            };
            var success = dictionaryExample

            if(!success)
            {
                Console.WriteLine("It's already in the dictionary!");
            }


            var dictionaryExampleMore = new Dictioinary<int, List<string>>();*/

            //var listExample = new List<int>() {1,2,3};

            var result = ReturnTuple2();
            if(!result.success)
            {
                throw result.exception;
            }
            
        }

        public static (int key, int value, int numberOfSides ) ReturnTuple()
        {
            return (1, 1);
        }

        public static (bool success, int idkSomething, Exception exception) ReturnTuple2()
        {
            return (true, 1, null);
        }
    }
}
