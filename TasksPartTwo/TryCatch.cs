using System;

namespace TasksPartTwo
{
    namespace TryCatchFinally
    {
        public static class DiffExceptions
        {
            public static void TryFinally()
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y.ToString()}");
                }
                finally
                {
                    Console.WriteLine("Блок finally");
                }
            }
            public static void TryCatchWhen()
            {
                int x = 1;
                int y = 0;

                try
                {
                     Console.WriteLine(x / y);
                }
                catch (DivideByZeroException) when (y == 0)
                {
                    Console.WriteLine("y не должен быть равен 0");
                }
                catch (DivideByZeroException ex) when (ex.ToString().Length > 0)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public static void ExceptionProperties()
            {
                byte x = 200;
                try
                {
                    x = checked((byte)(x + 500));
                }
                catch (OverflowException ofex)
                {
                    Console.WriteLine(
                        "InnerException: {0}\n" +
                        "Message: {1}\n" +
                        "Source: {2}\n" +
                        "StackTrace: {3}\n" +
                        "TargerSite: {4}\n", 
                        ofex.InnerException,
                        ofex.Message,
                        ofex.Source,
                        ofex.StackTrace,
                        ofex.TargetSite);
                }
            }
        }
    }
}
