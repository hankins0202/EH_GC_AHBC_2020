using System;
using System.Collections.Generic;
using System.Linq;

namespace Week4Day1Array  //Exercise 47 collection examples
{
    class Program
    {

        private static bool UserContinueSelection { get; set; } = true;//quick and dirty way to get user continue. Get and set are property defining the behavor for getting the property.  default to get the value from calling it. Setting it will assign it by defaulting

        //static void Main(string[] args)
        //{


        //    //var stringList = new List<string>() { "Jason", "Better Jason" }; //<> Allegater brackets used to determine what kind of list.
        //    //stringList.Add("Cory"); //click dot after string name to see all kinds of methods for use.
        //    //stringList.RemoveAt(2);
        //    //var cory = stringList.ElementAt(2);
        //    //var result = stringList.Last(entry => entry.Contains("Jason"));//switch where to "Last". Linc provides all new syntax and methods that is more readable. "=>" is a lambda expression???. Lambda is not the only way to do this function. Predicate action or something to be done. could be a function could be a lambda.
        //    // we named entry, per each element using =>, does any contain "Jason"
        //    //".Last" without syntax will just be the last item. Calling up new variable in "entry". Declaration for each item in the list. Entry is refering to elements on the list. 
        //    /*foreach (var entry in stringList) //=> is similar to foreach loop just easier and simpler to write.
        //     {
        //     }*/

        //    var stringList = new List<string>();
        //    var dictionaryForUserInput = new Dictionary<int, string>(); //the key is going to be an int and the value is going to be a string. 



        //    Console.WriteLine("Hello, input some string");
            

        //    //collections still have an index. elementAT<>. Lists/Collections are still zero based.

        //    //var collectionwithArrayInside = new List<int[]>() { [1, 2, 3], [2, 3, 4]};//not what you think.  You will have a collection entry per array. Question can a collection use an array

            

        //    while (UserContinueSelection == true)
        //    {
        //        var userInput = Console.ReadLine();
        //        //stringList.Add(userInput);
        //        var userInput2 = Console.ReadLine();
        //        //stringList.Add(userInput2);
        //        stringList.AddRange(new List<string> { userInput, userInput2 });//enumerable. instead of using add multiple times, can use add range at once.
        //        //collections are using and sharing the same logic through object oriented programming to coding.  Can draw from collections and ienumerable and list.

        //        foreach (var item in stringList)
        //        {
        //            Console.WriteLine(item);
        //        }

        //        UserContinue();//add method
        //    }
        //}

        static void main()
        {

            ////var somecomplexobject = new {FirstName = "Shari", MiddleName ="Unknown", }
            //                                          //Key  InputValueType     can do define key as string
            //var dictionaryForUserInput = new Dictionary<int, string>() { { 0, "Sandy" }, { 1, "Bernard" } }; //the key is going to be an int and the value is going to be a string. 
            //dictionaryForUserInput.Add(0, "Shari");//same as above.  Would receive an error because the key in this case zero is already used and will not replace. 
            ////to replace entry remove it and then readd under new value
            //dictionaryForUserInput.TryGetValue(1, out var bernard);//lower case bernard is a new variable we are trying to find the value of index 1.
            //var bernardkey = dictionaryForUserInput.First(entry => entry.Value.Contains("Bernard"));
            //Console.WriteLine($"We found {bernard}");
            while (UserContinueSelection == true)
            {

                var dictionaryofuserinput = new Dictionary<int, string>();
                Console.WriteLine("Hellow input some string!");
                var userInput = Console.ReadLine();
                Console.WriteLine("input another string!");
                var userInput2 = Console.ReadLine();

                var listofuserinputs = new List<string>();
                listofuserinputs.AddRange(new List<string> { userInput, userInput2});

                foreach (var item in listofuserinputs)
                {
                    dictionaryofuserinput.Add(listofuserinputs.FindIndex(entry => entry.Contains(item)), item);
                }

                UserContinue();//add method
            }
        }

        private static void UserContinue()
        {
            Console.WriteLine("Do you desire to continue");
            var userDesire = Console.ReadLine();

            if(userDesire.Contains("Y", StringComparison.InvariantCultureIgnoreCase))
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
