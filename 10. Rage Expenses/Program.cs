using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;
            int keyboardsBroken = 0;

            for (int i = 1 ; i <= lostGamesCount; i++)
            {
                bool isHeadsetBroken = false;
                bool isMouseBroken = false;
                if (i %2 == 0)
                {
                    expenses += headsetPrice;
                    isHeadsetBroken = true;
                }
                 if (i % 3 == 0)
                {
                    expenses += mousePrice;
                    isMouseBroken = true;
                }
                 if (isHeadsetBroken == true && isMouseBroken == true)
                {
                    expenses += keyboardPrice;
                    keyboardsBroken++;
                }
                 if (keyboardsBroken!=0  && keyboardsBroken % 2 == 0)
                {
                    expenses += displayPrice;
                    keyboardsBroken = 0;
                }


            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv."
);
        }
    }
}
