using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int byedFoodKg = int.Parse(Console.ReadLine());
            int foodGr = byedFoodKg * 1000;
            int sumEatFood = 0;

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Adopted")
                {
                    if (foodGr < sumEatFood)
                    {
                        Console.WriteLine($"Food is not enough. You need {sumEatFood - foodGr} grams more.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {foodGr - sumEatFood} grams.");
                        break;

                    }
                    
                }
                else
                {
                    sumEatFood += int.Parse(command);
                                       
                }
            }

            
        }
    }
}
