﻿using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine(sp);
            }
            Span<int> slice = mySpan.Slice(0, 10);
            Console.WriteLine(mySpan[0]);
            Console.WriteLine(slice[0]);
            mySpan[0] = 55555;
            Console.WriteLine(slice[0]); // ref T this[int index] in action
        }
        
    }
}
