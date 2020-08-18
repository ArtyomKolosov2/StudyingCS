using System;

namespace TasksPartThree.LocalFunctionsStudy
{
    public static class LocalFunctions
    {
        public static void StartExample()
        {
            Console.WriteLine(GetSum(5, 10));
        }
        public static int GetSum(int x, int y)
        {
            int result = 0;
            /*static void ShowVar()
            {
                Console.WriteLine(checkStaticVar);
            }*/
           
            if (IsGreater(x, 0) && IsGreater(y, 5))
            {
                result = x + y;
            }
            bool IsGreater(int num1, int num2)
            {
                return num1 > num2;
            }
            return result;
        }
    }
}
