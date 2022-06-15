using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalNumberOfLightsabers = Math.Ceiling(studentCount * 1.10);
            double numbersOfFreeBelts = Math.Floor(studentCount / 6.0);

            double finalPriceForSabers = totalNumberOfLightsabers * lightsaberPrice;
            double finalPriceForBelts = (studentCount - numbersOfFreeBelts) * beltPrice;
            double finalPriceForRobes = studentCount*robPrice;

            double totalFinalPrice = finalPriceForBelts + finalPriceForRobes + finalPriceForSabers;

            if (budget >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");

            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(totalFinalPrice-budget):f2}lv more.");

            }




        }
    }
}
