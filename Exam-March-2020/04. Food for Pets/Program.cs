using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double countDays = double.Parse(Console.ReadLine());
            double commonCountFood = double.Parse(Console.ReadLine());
            double sumOfEatFood = 0;
            double sumEatFoodDog = 0;
            double sumEatFoodCat = 0;
            double biscuits = 0;

            for (int i = 1; i <= countDays; i++)
            {
                int countFoodDog = int.Parse(Console.ReadLine());
                int countFoodCat = int.Parse(Console.ReadLine());
                sumOfEatFood += countFoodCat + countFoodDog;
                sumEatFoodDog += countFoodDog;
                sumEatFoodCat += countFoodCat;
                if (i % 3 == 0)
                {
                    biscuits += (countFoodCat + countFoodDog) * 0.1;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{sumOfEatFood / commonCountFood * 100:F2}% of the food has been eaten.");
            Console.WriteLine($"{sumEatFoodDog / sumOfEatFood * 100:F2}% eaten from the dog.");
            Console.WriteLine($"{sumEatFoodCat / sumOfEatFood * 100:F2}% eaten from the cat.");

        }
    }
}
