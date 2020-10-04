using Studying_CS.IOservices;
using System.Threading;

namespace TaskPartFour.ThreadStudy
{
    public static class ThreadsStudy
    {
        public static void StartExample()
        {
            Thread thread1 = new Thread(PrintOnlyEven);
            Thread thread2 = new Thread(() => PrintOnlyOdd());
            thread1.Start();
            thread2.Start();
        }

        public static void PrintOnlyEven()
        {
            for (int i = 0; i < 20; i += 2)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(i);
                Thread.Sleep(300);
            }
        }

        public static void PrintOnlyOdd()
        {
            for (int i = 1; i < 20; i += 2)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(i);
                Thread.Sleep(300);
            }
        }
    }
}
