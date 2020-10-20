using System;
using System.Collections;

namespace Studying_CS.IOservices
{
    public static class IOService
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

        public static void ShowUserStringWithOutLineBreak(object obj)
        {
            Console.Write(obj);
        }

        public static void ShowUserStringWithOutLineBreak(string info)
        {
            Console.Write(info);
        }

        public static void ShowUserStringWithLineBreak(object obj)
        {
            Console.WriteLine(obj);
        }

        public static void ShowCollectionWithLineBreak(IEnumerable collection)
        {
            foreach (var element in collection)
            {
                ShowUserStringWithLineBreak(element);
            }
        }

        public static void ShowCollectionWithSplitter(IEnumerable collection, string splitter=" ")
        {
            foreach (var element in collection)
            {
                ShowUserStringWithOutLineBreak($"{element}{splitter}");
            }
            ShowUserStringWithOutLineBreak("\n");
        }
    }
}
