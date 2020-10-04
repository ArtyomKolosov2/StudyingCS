using TaskPartFour.IEnumerableStudy;
using TaskPartFour.LazyStudy;
using TaskPartFour.SpanStudy;
using TaskPartFour.ThreadStudy;
using TaskPartFour.YieldStudy;

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
            Program.center(amount, "Yield keyword", splitter);
            YieldKeyword.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Lazy loading", splitter);
            LazyInit.StartExample(); // You can place breakpoint to see difference in memory concumed
            //////////////////////////////////////////////          
            Program.center(amount, "Spans", splitter);
            SpanStudy.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Threads", splitter);
            ThreadsStudy.StartExample();

        }
    }


}
