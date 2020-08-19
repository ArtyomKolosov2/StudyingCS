using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TaskPartFour.IEnumerableStudy;

namespace Studying_CS
{
    public static class Part4
    {
        public static void PartFourStart()
        {
            int amount = 50;
            string splitter = "=";
            Program.center(amount, "Start of The Four Part", "*");
            //////////////////////////////////////////////
            Program.center(amount, "IEnumerable and IEnumerator", splitter);
            IEnumerableStudy.StartExample();
            //////////////////////////////////////////////
        }
    }

    
}
