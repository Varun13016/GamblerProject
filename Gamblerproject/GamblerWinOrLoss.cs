using System;
using System.Collections.Generic;
using System.Text;

namespace Gamblerproject
{
    public class GamblerWinOrLoss
    {
        public static void WinOrLoss()
        {
            int Start = 100;

            Random random = new Random();

            int n = random.Next(2);

            if (n == 1)
            {
                Start++;

                Console.WriteLine("Gambler Win the $1 bet");
                Console.WriteLine("Your current Stack is : " + Start);
            }
            else
            {
                Start--;
                Console.WriteLine("Gambler Loss the $1 bet");
                Console.WriteLine("Your current Stack is : " + Start);
            }

        }
    }
}
