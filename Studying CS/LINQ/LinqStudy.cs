﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Studying_CS.LINQ
{
    public static class LinqStudy
    {
        public static void StartExample()
        {
            string[] strings = new string[] { "Artyom", "Ilya", "Egor", "Ivan", "Vasya", "Petya", "Jhonny", "Anna" };
            var resultStr = from t in strings
                            where t.ToUpper().StartsWith("A")
                            orderby t descending
                            select t;
            foreach (var res in resultStr)
            {
                Console.WriteLine(res);
            }
        }
    }
}
