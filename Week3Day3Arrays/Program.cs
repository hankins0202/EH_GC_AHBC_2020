using System;

namespace Week3Day3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] arrayOne = new int[5]; //initializing array, int type is collection of integers. This array cannot change.  Use keyword "new".  5 refers to 5 things or 5 numbers in this case. All arrays have an index startinng at 0.
            arrayOne[0] = 1; //assigning value in postion zero.  Array indexing begins at 0 in C#
            arrayOne[1] = 2;
            arrayOne[2] = 3;
            arrayOne[3] = 4;
            arrayOne[4] = 6;
            //arrayOne[5] = 6;  error would occur on this line because there are too many elements


            //aside new keyword is not necessary to creat an array.


            //second way to initialize array
            int[] arrayTwo = new int[] { 1, 2, 3, 4, 4, 5, 6 }; //c# initilizer.  We don't have to specify the length
            for (int i = 0; 0 < arrayTwo.Length; i++)//access elements in array.  Standard asked on interview questions.
            {
                Console.WriteLine(arrayTwo[i]);  //Access all elements
            }



            char[] charArray = { 'D', 'E' };

            //reference type vs value type Interview question
            int[] arrayThree = arrayTwo; //array three is a value type in this case and array two is a reference type in this case
            arrayThree[1] = 100; //second index for array three and two will both change to 100. Collections are a u

            //bottem line if three is referening two, if changed in three it is also changed in two!!

            //Collection itself is a reference type and will be a reference type.  Don't confuse data in array.

            //causes issues later down the road because values could be changed often, paradigm issue. 


            //Value types
            int one = 100;
            int two = one;
            two = 2000;//run one stays the same and two will change to 2000 because its a value type and stored vs reference type which


            var nestedArrays = GetNestedArray();

            PrintNestedArrays(nestedArrays);

        }

        private static void PrintNestedArrays(int[][] nestedArrays)
        {
            for (int i = 0; i<nestedArrays.Length; i++)//length is neede to end the loop.  Length refers to number of elements in array
            {
                for (int j=0; j<nestedArrays.Length; i++)
                {

                    Console.WriteLine($"{nestedArrays[i][j]}");
                    //for third row another nested array is need with k=0
                }

            }
            foreach (var array in nestedArrays)//Foreach and for loops will do the same thing
            {
                foreach (var number in array)
                {
                    Console.WriteLine(number);

                }
            }
        }
        //Can use a foreach loop and this is user preference

        //Example using a method

        private static int[][] GetNestedArray()
        {
            int[][] nestedArray = new[]
            {
                       //j 0, 1, 2, 3, 4              i
                new int[] {1, 2, 3, 4, 5 },         //0
                new int[] {6, 7, 8, 9},       //1
                new int[] {10,11,12,13,14,15}   //2
            };
            return nestedArray;
        }
    }
}
