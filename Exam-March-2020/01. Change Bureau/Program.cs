using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            //19:07

            int countBitcoins = int.Parse(Console.ReadLine());
            double countJoans =double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            int sumOfBitcoins = countBitcoins * 1168;
            double sumOfJoans = 0.15 * countJoans;
            double sumOfDollars = sumOfJoans;
            double sumOfLv = sumOfDollars * 1.76;

            double sumOfBitcoinsJoans = sumOfLv + sumOfBitcoins;
            double sumBandJinEuro = sumOfBitcoinsJoans / 1.95;

            double getCommision = sumBandJinEuro * comission / 100;

            double allMonney = sumBandJinEuro - getCommision;

            Console.WriteLine($"{allMonney:F2}");
        }
    }
}
