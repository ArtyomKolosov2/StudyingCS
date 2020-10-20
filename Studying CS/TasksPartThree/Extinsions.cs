using Studying_CS.IOservices;

namespace TasksPartThree
{
    namespace StudyExtinsions
    {
        public class Extinsions
        {
            public void StartExample()
            {
                string ex = "ABCAAC";
                string ex2 = "qwerty\n\t\r";
                IOService.ShowUserStringWithLineBreak(ex.CountSymbols('A'));
                IOService.ShowUserStringWithLineBreak(ex2.FindTrueLength());
            }
        }



        public static class StringExtinsions
        {
            public static int CountSymbols(this string str, char c)
            {
                int result = 0;
                foreach (var symbol in str)
                {
                    if (symbol == c)
                    {
                        result++;
                    }
                }
                return result;
            }

            public static int FindTrueLength(this string str)
            {
                int result = 0;
                foreach (var s in str)
                {
                    if (char.IsControl(s) == false)
                    {
                        result++;
                    }
                }
                return result;
            }
        }
    }
}
