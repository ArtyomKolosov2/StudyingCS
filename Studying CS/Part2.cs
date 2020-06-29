using System;
using TasksPartTwo.TryCatchFinally;

namespace Studying_CS
{
    public static class Part2
    {
        public static void PartTwoStart()
        {
            int amount = 50;
            string splitter = "=";
            Program.center(amount, "Start of The Second Part", "*");
            Program.center(amount, "TryCatchFinally", splitter);
            DiffExceptions.TryCatchWhen();
            try
            {
                DiffExceptions.TryFinally();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception ({0}) wasnt handled because of TryFinally construction", ex.Source);
            }
            Program.center(amount, "ExceptionProperties", splitter);
            DiffExceptions.ExceptionProperties();
            Program.center(amount, "The End of The Second Part", "*");
        }
    }
}
