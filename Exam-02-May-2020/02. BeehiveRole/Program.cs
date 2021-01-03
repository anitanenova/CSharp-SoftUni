using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            int intelect = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            string typeBee;
            if (intelect >= 80)
            {
                if (power >= 80 && sex == "female")
                {
                   
                        typeBee = "Queen Bee";
                        Console.WriteLine(typeBee);
                        return;
                    
                }
                else
                {
                    typeBee = "Repairing Bee";
                    Console.WriteLine(typeBee);
                    return;
                }
            }
            else if (intelect >= 60)
            {
                typeBee = "Cleaning Bee";
                Console.WriteLine(typeBee);
                return;
            }
            else
            {
                if (power >= 80 && sex == "male")
                {
                 
                        typeBee = "Drone Bee";
                        Console.WriteLine(typeBee);
                        return;
                    

                }
                else if (power >= 60)
                {
                    typeBee = "Guard Bee";
                    Console.WriteLine(typeBee);
                    return;
                }
                else
                {
                    typeBee = "Worker Bee";
                    Console.WriteLine(typeBee);
                    return;

                }
            }


        }
    }
}