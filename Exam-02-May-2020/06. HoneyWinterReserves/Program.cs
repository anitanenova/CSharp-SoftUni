using System;

namespace _06._Honey_Winter_Reserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double countHonney = double.Parse(Console.ReadLine());

            string nameBee = Console.ReadLine();
            double sumHonneyToBee = 0;
            double allHonneyFromAllBees = 0;
            int mounts = 6;

            while (nameBee != "Winter has come")
            {
                for (int i = 1; i <= mounts; i++)
                {
                    double honneyToBee = double.Parse(Console.ReadLine());
                     sumHonneyToBee += honneyToBee;
                    allHonneyFromAllBees += honneyToBee;
                }
                if (sumHonneyToBee < 0)
                {
                    Console.WriteLine($"{nameBee} was banished for gluttony");
                }
                if (allHonneyFromAllBees > countHonney)
                {
                    Console.WriteLine($"Well done! Honey surplus {allHonneyFromAllBees - countHonney:F2}.");
                    break;
                }
                sumHonneyToBee = 0;
                nameBee = Console.ReadLine();
            }
            if (nameBee == "Winter has come")
            {
                if (countHonney - allHonneyFromAllBees > 0.00)
                {
                    Console.WriteLine($"Hard Winter! Honey needed {countHonney - allHonneyFromAllBees:F2}.");
                }
                else
                {
                    Console.WriteLine($"Well done! Honey surplus {sumHonneyToBee - allHonneyFromAllBees:F2}.");
                }
            }
        }
    }
}

