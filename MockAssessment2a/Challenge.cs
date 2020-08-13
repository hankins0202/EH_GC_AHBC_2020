using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAssessment2a
{
    public class Challenge
    {
        public static int AddStarWarsCharacters(string[] CharacterArray)
        {
            return Array.IndexOf(CharacterArray, "Yoda");
        }

        public static string DeathStarCombat(Dictionary<string, int> JediAttackValues)
        {
            var JediAttackValues = AddStarWarsCharacters
            return JediAttackValues.Values.GetEnumerator(MaxValue);

        }

        public static List<string> ConvertPlanets(string[] PlanetArray)
        {
            return PlanetArray.Reverse().ToList();
        }

        public static int AverageDroids(List<int> NumberOfDroids)
        {
            int DroidEven = 0;
            int CountDroids = 0;
            foreach (var Droid in NumberOfDroids)
            {
                if (Droid % 2 == 0)
                {
                    DroidEven += Droid;
                    CountDroids++;
                }
            }
            return DroidEven / CountDroids;
        }
        public static string TryToCatchDarthVader(string ParseToInt)
        {
            try
            {
                int.Parse(ParseToInt);
                return "Vader Was Captured!";
            }
            catch
            {
                return "Vader Got Away!";
            }
        }
    }
}

