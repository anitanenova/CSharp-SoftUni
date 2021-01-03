using System;

namespace _04._Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int nachalnaPopulaciq = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int ostatukZaDrGod = 0;
            int izlupeni = 0;
            int izmreli = 0;
            int ostatuk = 0;
            int migrirali = 0;

            for (int i = 1; i <= years; i++)
            {
                
                if (i == 1)
                {
                    izlupeni = nachalnaPopulaciq / 10 * 2;
                    izmreli = (nachalnaPopulaciq + izlupeni) / 20 * 2;

                    ostatuk = nachalnaPopulaciq + izlupeni - izmreli;

                
                }
                else if(i % 5 == 0)
                {
                    izlupeni = ostatuk / 10 * 2;
                    ostatuk = ostatuk + izlupeni;
                    migrirali = ostatuk / 50 * 5;
                    izmreli = (ostatuk - migrirali) / 20 * 2;
                    ostatuk = ostatuk - migrirali - izmreli;
                }
                else 
                {
                    izlupeni = ostatuk / 10 * 2;
                    izmreli = (ostatuk + izlupeni) / 20 * 2;

                    ostatuk = ostatuk + izlupeni - izmreli;

                }



            }
                Console.WriteLine($"Beehive population: {ostatuk}");

                
            
            

        }
    }
}
