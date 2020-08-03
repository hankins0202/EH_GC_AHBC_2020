using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise48
{
    class Program
    {
        static void Main(string[] args)
        {
          bool again = true;
          IEnumerable<int> userList = Enumerable.Empty<int>();//Enumerable is the interface.  Least functionality of all collections. IList inherits from IEnumerable. Base class or lowest class 90% will be IList. IList is used most.  Most Functionality
          while(true)
           {
                Console.WriteLine("Enter a number. q to quit");
               string UserInput = Console.ReadLine();
                userList = userList.Append(UserInput);
                if (UserInput == "q")
                {
                    again = false;
                }
           }

          userList.Sum();
        }

        
    }
}
