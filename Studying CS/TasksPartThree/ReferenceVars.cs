using Studying_CS.IOservices;
using System;

namespace TasksPartThree.ReferenceVars
{
    public static class ReferenceVars
    {
        public static void StartExample()
        {
            int a = 2;
            int b = 5;
            ref int result = ref GetGreater(ref a, ref b);
            ConsoleIOService.ShowUserStringWithLineBreak(result);
            // С C# 7.3 появилась возможность переназначать переменные ссылки
            ref int aRef = ref a;
            // ref int Error; - так делать нельзя!!!
            aRef = 45;
            aRef = ref b;
            ConsoleIOService.ShowUserStringWithLineBreak(aRef);
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
            numberRef = 9; // заменяем 4 на 9
            ConsoleIOService.ShowUserStringWithLineBreak(numbers[3]); // 9
        }

        public static ref int GetGreater(ref int n1, ref int n2) // Параметры должны быть определены с мод. ref!!!
        {

            if (n1 >= n2)
            {
                return ref n1;
            }
            else
            {
                return ref n2;
            }
        }

        static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
                }
            }
            throw new IndexOutOfRangeException("число не найдено");
        }
    }
}
