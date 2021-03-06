﻿using Studying_CS.IOservices;
using System;

namespace TasksPartTwo
{
    namespace StudyDelegates
    {
        public class LambdaFunctions
        {
            private delegate int OperationMulti(int x, int y);

            private delegate int Square(int x);

            private delegate void ShowSmt();

            private delegate void RefHandler(ref int x);

            private delegate void ShowHandler();

            private delegate bool IsCondition(int num);

            public void Start()
            {
                int refx = 0;
                Square square = x => x * x;
                OperationMulti multi = (x, y) => x * y;
                ShowSmt show = () => IOService.ShowUserStringWithLineBreak("Lambda Without Arguments!");
                RefHandler refHandler = (ref int x) => x += 5;
                ShowHandler showHandler = () => ShowMessage();


                IOService.ShowUserStringWithLineBreak(multi(5, 5).ToString());
                IOService.ShowUserStringWithLineBreak(square(10).ToString());
                show();
                refHandler(ref refx);
                IOService.ShowUserStringWithLineBreak($"Refx = {refx}");
                showHandler();

                int[] Array = new int[] { 5, 6, 3, 5, 1, 10, 10 };
                IsCondition condition = (int x) => x > 5;
                SumArrayNumbers(Array, condition);
            }

            private void SumArrayNumbers(int[] array, IsCondition condition)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    if (condition(num))
                    {
                        sum += num;
                    }
                }
                IOService.ShowUserStringWithLineBreak($"Sum with bool expression x > 5 = {sum}");
            }

            private void ShowMessage()
            {
                IOService.ShowUserStringWithLineBreak("Hello from lambda!!!");
            }
        }
        public class AnonimMethods
        {
            public delegate void ShowDelegate(string mes);

            public delegate int SumHandler(int x, int y);

            public ShowDelegate ShowOne { get; set; }
            public ShowDelegate ShowTwo { get; set; }

            public SumHandler SumOne { get; private set; }
            public SumHandler SumTwo { get; private set; }


            public void StartExample()
            {
                ShowOne = delegate (string message)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    IOService.ShowUserStringWithLineBreak(message);
                    Console.BackgroundColor = ConsoleColor.White;
                };
                ShowMessage("Hello from first anonim example!", ShowOne);
                ShowMessage("Hello from second anonim example!", ShowTwo = delegate (string message) // Объявление непосредственно перед
                // передачей в метод
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    IOService.ShowUserStringWithLineBreak(message);
                    Console.BackgroundColor = ConsoleColor.White;
                });
                ShowSum("Third function (returns int)", delegate (int x, int y)
                {
                    return x + y;
                });
                ShowMessage("ExampleNumberFour", delegate
                {
                    IOService.ShowUserStringWithLineBreak("Nice One!");
                });

                SumTwo = delegate (int x, int y)
                {
                    IOService.ShowUserStringWithLineBreak("SumTwo anonim");
                    return x + y;
                };

                SumTwo(5, 10);
            }

            private void ShowMessage(string message, ShowDelegate show)
            {
                show(message);
            }

            private void ShowSum(string message, SumHandler show)
            {
                Console.Write(message + " ");
                IOService.ShowUserStringWithLineBreak(show(5, 5));
            }

        }
        // The End of Anonim Methods part
        internal class Example
        {
            public void ShowDelMessage()
            {
                IOService.ShowUserStringWithLineBreak("This Message Was Called from example class!");
            }
        }

        public class State
        {
            public delegate void ChangeState(string message, int sumAmount);
            public ChangeState _state { get; set; } = null;

            public int Sum { get; set; }

            public State(int sum)
            {
                Sum = sum;
            }
            public void RegisterState(ChangeState newState)
            {
                _state = newState;
            }

            public void UnregisterState(ChangeState deleteState)
            {
                _state -= deleteState;
            }

            public void DoTheThing()
            {
                if (Sum > 0)
                {
                    Sum -= 50;
                    _state?.Invoke("Сумма уменьшена, остаток = ", Sum);

                }
                else
                {
                    _state?.Invoke("Error: Сумма не уменьшена,т.к. остаток = ", Sum);
                }
            }
        }
        public class Delegates
        {
            public delegate void ShowMsg();

            public delegate int Operations(int x, int y);

            delegate T Operation<T, K>(K val);
            public int currentHour { get; private set; }

            public void FirstExample()
            {
                currentHour = DateTime.Now.Hour;
                ShowMsg msg = null;
                if (currentHour < 12)
                {
                    msg = ShowGoodMorning;
                }
                else
                {
                    msg = ShowGoodEvening;
                }
                if (msg != null)
                {
                    msg();
                }
            }

            public void SecondExample()
            {
                Operations operations;
                operations = OperationMulti;
                IOService.ShowUserStringWithLineBreak(operations(5, 5));
                operations = OperationSum;
                IOService.ShowUserStringWithLineBreak(operations(10, 10));
            }
            public void ThirdExample()
            {
                Example example = new Example();
                ShowMsg msg = new ShowMsg(example.ShowDelMessage);
                msg();
            }

            public void ExampleNumberFour()
            {
                ShowMsg show1;
                ShowMsg show2 = ThirdFunc;
                show1 = FirstFunc;
                show1 += SecondFunc; // Or -=
                show1 += show2; // Or -=
                show1();
            }

            public void ExampleNumberFive()
            {
                ShowMsg msg1 = null;
                ShowMsg msg2 = FirstFunc;
                msg1?.Invoke(); // This delegate will never calles, because it has null
                msg2?.Invoke();
            }

            public void ExampleNumberSix()
            {
                ShowMessage(ShowGoodEvening);
                ShowMessage(SecondFunc);
            }

            public void ExampleNumberSeven()
            {
                Operation<decimal, int> op = Square;
                IOService.ShowUserStringWithLineBreak(op(10));
            }
            private decimal Square(int n)
            {
                return n * n;
            }

            public void ShowMessage(ShowMsg _del)
            {
                _del?.Invoke();
            }
            private void ShowGoodMorning()
            {
                IOService.ShowUserStringWithLineBreak("Good Morning, friend!");
            }

            private void FirstFunc()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                IOService.ShowUserStringWithLineBreak("First Func");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            private void SecondFunc()
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                IOService.ShowUserStringWithLineBreak("Second Func");
                Console.BackgroundColor = ConsoleColor.White;

            }

            private void ThirdFunc()
            {
                IOService.ShowUserStringWithLineBreak("Third Func from another delegate");
            }

            private int OperationMulti(int x, int y)
            {
                return x * y;
            }

            private int OperationSum(int x, int y)
            {
                return x + y;
            }
            private void ShowGoodEvening()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                IOService.ShowUserStringWithLineBreak("Good Evening, my friend!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}
