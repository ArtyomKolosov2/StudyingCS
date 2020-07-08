using System;

namespace Studying_CS
{
    static class Program
    {
        static void Main()
        {
            int partAmount = 2;
            string Command;
            Console.WriteLine($"Choose part (1-{partAmount.ToString()}):");
            Command = Console.ReadLine();
            switch (Command) 
            {
                case "1":
                    Part1.PartOneStart();
                    break;
                case "2":
                    Part2.PartTwoStart();
                    break;
                default:
                    Console.WriteLine("Error: Incorrect Part!");
                    break;
            }
        }
        public static void center(int amount, string msg, string symbol)
        {
            int divided_amount = amount / 2;
            for (int i = 0; i < amount; i++)
            {

                if (i == divided_amount)
                {
                    Console.Write(msg);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.Write("\n");
        }
        public static void print_splitter(int amount, string splitter)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(splitter);
            }
            Console.Write("\n");
        }


    }
}
