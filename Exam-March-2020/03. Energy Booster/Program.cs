using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeFruit = Console.ReadLine();
            string size = Console.ReadLine();
            int countOrderSets = int.Parse(Console.ReadLine());
            double price = 0;
            double sumOrder = 0;

            if (size == "small")
            {
                switch (typeFruit)
                {
                    case "Watermelon":
                        price = 56;
                        break;
                    case "Mango":
                        price = 36.66;
                        break;
                    case "Pineapple":
                        price = 42.10;
                        break;
                    case "Raspberry":
                        price = 20;
                        break;                    
                    default:
                        break;
                }
                sumOrder = price * 2 * countOrderSets;
            }
            else if (size == "big")
            {
                switch (typeFruit)
                {
                    case "Watermelon":
                        price = 28.70;
                        break;
                    case "Mango":
                        price = 19.60;
                        break;
                    case "Pineapple":
                        price = 24.80;
                        break;
                    case "Raspberry":
                        price = 15.20;
                        break;
                    default:
                        break;
                }
                sumOrder = price * 5 * countOrderSets;
            }

            if (sumOrder == 400)
            {
                sumOrder = sumOrder - (sumOrder * 0.15);
            }
            else if (400 < sumOrder && sumOrder <= 1000)
            {
                sumOrder = sumOrder - (sumOrder*0.15);
            }
            else if (sumOrder > 1000)
            {
                sumOrder = sumOrder - (sumOrder / 2);
            }
            

            Console.WriteLine($"{sumOrder:F2} lv.");
           
        }
    }
}
