using System;

namespace _05._Beehive_Defense
{
    class Program
    {
        static void Main(string[] args)
        {

            int countBees = int.Parse(Console.ReadLine());
            int zdraveBeer = int.Parse(Console.ReadLine());
            int ataka = int.Parse(Console.ReadLine());
            
            int restCountBees = 0;
            int restZdraveBeer;

            while (true)
            {
                restCountBees = countBees - ataka;
                restZdraveBeer = zdraveBeer - restCountBees * 5;
                               
                if (restCountBees < 100)
                {
                    if (restCountBees < 0)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {0}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {restCountBees}.");
                        break;
                    }

                    

                } else if (restZdraveBeer <=0)
                {
                    Console.WriteLine($"Beehive won! Bees left {restCountBees}.");
                    break;
                }
                countBees = restCountBees;
                zdraveBeer = restZdraveBeer;
            }
        }
    }
}
