using System;

namespace Gamblerproject
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash, betAmount;
            Console.WriteLine("Welcome to Gambler Game");
            Console.WriteLine("Please Enter Cash Amount");
            cash = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Bet Amount");
            betAmount = double.Parse(Console.ReadLine());
        }
    }
}
