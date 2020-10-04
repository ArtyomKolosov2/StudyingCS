using System;

namespace Studying_CS.IOservices
{
    public static class ConsoleIOService
    {
        public static string GetUserString()
        {
            return Console.ReadLine();
        }

        public static string[] GetUserString(int strAmount)
        {
            string[] resultStrings = new string[strAmount];
            for (int i = 0; i < strAmount; i++)
            {
                resultStrings[i] = GetUserString();
            }
            return resultStrings;
        }
        public static void ShowUserStringWithLineBreak(string info)
        {
            Console.WriteLine(info);
        }

        public static void ShowUserStringWithOutLineBreak(string info)
        {
            Console.Write(info);
        }

        public static void ShowUserStringWithLineBreak(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
