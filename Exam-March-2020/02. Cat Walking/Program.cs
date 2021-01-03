using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalkPerDay = int.Parse(Console.ReadLine());
            int countWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int sumMinutes = minutesWalkPerDay * countWalks;
            int sumIzgoreniCalories = sumMinutes * 5;
            if (sumIzgoreniCalories >= calories/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {sumIzgoreniCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {sumIzgoreniCalories}.");
            }
        }
    }
}
