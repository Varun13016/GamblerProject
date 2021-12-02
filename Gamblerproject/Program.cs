using System;

namespace Gamblerproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom Gambling Stimulation Progarm \n");

            GamblerWinOrLoss obj = new GamblerWinOrLoss();

            obj.WinOrLoss();
        }
    }
}
