using Studying_CS.IOservices;
using System;

namespace TaskPartFour.SpanStudy
{
    public class SpanStudy
    {
        public static void StartExample()
        {
            int[] temperatures = new int[]
            {
                10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
                18, 16, 15, 16, 17, 14,  9,  8, 10, 11,
                12, 14, 15, 15, 16, 15, 13, 12, 12, 11
            };
            Span<int> mySpan = temperatures;
            foreach (var sp in mySpan)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(sp);
            }
            Span<int> slice = mySpan.Slice(0, 10);
            ConsoleIOService.ShowUserStringWithLineBreak(mySpan[0]);
            ConsoleIOService.ShowUserStringWithLineBreak(slice[0]);
            mySpan[0] = 55555;
            ConsoleIOService.ShowUserStringWithLineBreak(slice[0]); // ref T this[int index] in action
        }

    }
}
