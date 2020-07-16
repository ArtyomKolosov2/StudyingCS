using System;
using TasksPartTwo.TryCatchFinally;
using TasksPartTwo.StudyDelegates;
using TasksPartTwo.StudyEvents;
using TasksPartTwo.StudyDelegates.StudyCovariance;
using TasksPartTwo.StudyInterfaces;
using TasksPartTwo.StudyDelegates.MainCSDelegates;

namespace Studying_CS
{
    public static class Part2
    {
        public static void ShowState(string msg, int amount)
        {
            Console.WriteLine(msg + amount.ToString());
        }

        public static void ShowStateRed(string msg, int amount)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(msg + amount.ToString());
            Console.BackgroundColor = ConsoleColor.White;
        }
        public static void PartTwoStart()
        {
            int amount = 50;
            string splitter = "=";
            Program.center(amount, "Start of The Second Part", "*");
            //////////////////////////////////////////////
            Program.center(amount, "TryCatchFinally", splitter);
            DiffExceptions.TryCatchWhen();
            try
            {
                DiffExceptions.TryFinally();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception ({0}) wasnt handled because of TryFinally construction", ex.Source);
            }
            Program.center(amount, "ExceptionProperties", splitter);
            DiffExceptions.ExceptionProperties();
            /////////////////////////////////////////////
            Program.center(amount, "Delegates", splitter);
            Delegates delegates = new Delegates();
            delegates.FirstExample();
            delegates.SecondExample();
            delegates.ThirdExample();
            delegates.ExampleNumberFour();
            delegates.ExampleNumberFive();
            delegates.ExampleNumberSix();
            delegates.ExampleNumberSeven();
            /////////////////////////////////////////////
            Program.center(amount, "Using of Delegates", splitter);
            State state = new State(100);
            state.RegisterState(ShowState);
            state.DoTheThing();
            state.DoTheThing();
            state.UnregisterState(ShowState);
            state.RegisterState(ShowStateRed);
            state.DoTheThing();
            /////////////////////////////////////////////
            Program.center(amount, "Using of AnonimMethods", splitter);
            AnonimMethods anonim = new AnonimMethods();
            anonim.StartExample();
            /////////////////////////////////////////////
            LambdaFunctions lambda = new LambdaFunctions();
            lambda.Start();
            /////////////////////////////////////////////
            Program.center(amount, "Using of Events", splitter);
            EventMain.MainEventExample();
            /////////////////////////////////////////////
            Program.center(amount, "Covariance and ContrCovariance", splitter);
            StudyCovariance covariance = new StudyCovariance();
            covariance.StartExample();
            /////////////////////////////////////////////
            Program.center(amount, "Delegates Action, Predicate, Func", splitter);
            ActionDel.StartExample();
            /////////////////////////////////////////////
            Program.center(amount, "Interfaces", splitter);
            Interfaces.StartExample();
            /////////////////////////////////////////////
            Program.center(amount, "The End of The Second Part", "*");
        }
    }
}
