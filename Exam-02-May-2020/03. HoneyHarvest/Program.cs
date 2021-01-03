using System;

namespace _03._Honey_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeFlower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countHoney = 0;

            int counPoluchenhomey;
            if (season == "Summer")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                        countHoney = 8 + (8 * 10 / 100);
                        break;
                    case "Daisy":
                        countHoney = 8;
                        break;
                    case "Lavander":
                        countHoney = 8;
                        break;
                    case "Mint":
                        countHoney = 12;
                        break;
                    default:
                        break;
                }

                counPoluchenhomey = count * countHoney;
                Console.WriteLine($"Total honey harvested: {counPoluchenhomey:F2}");
            }
            else if (season == "Autumn")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                        countHoney = 12;
                        break;
                    case "Daisy":
                        countHoney = 6;
                        break;
                    case "Lavander":
                        countHoney = 6;
                        break;
                    case "Mint":
                        countHoney = 6;
                        break;
                    default:
                        break;
                }

                counPoluchenhomey = count * countHoney * 95/100;
                Console.WriteLine($"Total honey harvested: {counPoluchenhomey:F2}");

            }
            else if (season == "Spring")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                        countHoney = 10;
                        break;
                    case "Daisy":
                        countHoney = 12 + (12 * 10/100);
                        break;
                    case "Lavander":
                        countHoney = 12;
                        break;
                    case "Mint":
                        countHoney = 10 + (10 * 10/100);
                        break;
                    default:
                        break;
                }

                counPoluchenhomey = count * countHoney;
                Console.WriteLine($"Total honey harvested: {counPoluchenhomey:F2}");

            }

        }
    }
}
