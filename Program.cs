using System;

namespace _01. Honeycombs
{
    class Program
{
        static void Main(string[] args)
        {

            int coutBeeps = int.Parse(Console.ReadLine());
            int countFlowers = int.Parse(Console.ReadLine());

            double sumGramaMed = coutBeeps * 0.21 * countFlowers;
            double restHoney = sumGramaMed % 100;

            double countPiti  = sumGramaMed - restHoney;

            Console.WriteLine($"{countPiti/100} honeycombs filled.");
            Console.WriteLine($"{restHoney:F2} grams of honey left.");
        
        }
    }
}
