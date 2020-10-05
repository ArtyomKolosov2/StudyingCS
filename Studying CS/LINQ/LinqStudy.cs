using Studying_CS.IOservices;
using System.Collections.Generic;
using System.Linq;

namespace Studying_CS.LINQ
{
    public static class LinqStudy
    {
        public static void StartExample()
        {
            int amount = 50;
            string split = "=";
            string[] strings = new string[] { "Artyom", "Ilya", "Egor", "Ivan", "Vasya", "Petya", "Jhonny", "Anna" };
            var resultStr = from t in strings
                            where t.ToUpper().StartsWith("A")
                            orderby t descending
                            select t;
            foreach (var res in resultStr)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(res);
            }
            Program.center(amount, "Second-example", split);
            var selectedItem = (strings.Where(t=> t.Length==4)).OrderByDescending(t=>t);
            foreach (var res in selectedItem)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(res);
            }
            Program.center(amount, "Third-example", split);
            int[] myArray = new int[] { 1, 2, 4, -34, 43, 34, 2,-41,-32, 123, 13, 12, 3, 1, 123, 1443, 423, 1, 2 };
            IEnumerable<int> result = (from t in myArray
                                      where t % 2 == 0 && t > 0
                                      orderby t descending
                                      select t).Distinct();
            foreach (var res in result)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(res);
            }
        }
    }
}
