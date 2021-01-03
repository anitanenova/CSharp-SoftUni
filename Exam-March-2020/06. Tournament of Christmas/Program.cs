using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            
            double sumWinMonney = 0;
            
            int countWinDays = 0; 
            int countLoseDays = 0;

            for (int i = 0; i < countDays; i++)
            {
                double sumWinMonneyPerDay = 0;
                int countWin = 0;
                int countLose = 0;
                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        sumWinMonneyPerDay += 20;
                        countWin++;
                    }
                    else if (result == "lose")
                    {
                        countLose++;
                    }

                    sport = Console.ReadLine();
                }
                if (countWin > countLose)
                {
                    sumWinMonney = sumWinMonney + sumWinMonneyPerDay + sumWinMonneyPerDay * 0.10;
                    countWinDays++;
                }
                else
                {
                    sumWinMonney = sumWinMonney + sumWinMonneyPerDay;
                    countLoseDays++;
                }
            }

            if (countWinDays > countLoseDays)
            {
                sumWinMonney = sumWinMonney + sumWinMonney * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {sumWinMonney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {sumWinMonney:F2}");
            }
        }
    }
}
