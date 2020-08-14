using System;
using System.Collections.Generic;
using System.Text;
using TasksPartThree.StudyDeconstruction;

namespace TasksPartThree.StudyPatternMacthing
{
    public static class PatternMatching
    {
        public static void StartExample()
        {
            One first = new Two() { IsLegit=true};
            Two second = new Two();
            Two third = null;
            if (first is Two two1) // If pattern mathing
            {

            }
            switch (first)
            {
                case Two two when two.IsLegit:
                    break;
                case null:
                    break;
                default:
                    Console.WriteLine("NoPattern");
                    break;

            }
            Console.WriteLine(GetMessage(new Human { Age = 18 }));
            Console.WriteLine(GetMessage(new Human { Name="Artyom" }));
            Console.WriteLine(GetMessage(new Human { SurName="Kolosov" }));
            Console.WriteLine(GetMessage(new Human()));

            Console.WriteLine(GetOperationResult(1, 2, 2));
            try
            {
                Console.WriteLine(GetOperationResult(5, 2, 2));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(GetWelcome("english", null, null));
            Console.WriteLine(GetWelcome("rs", "morning", "sir"));

            Console.WriteLine(GetLanguageInfo(new Language { Name = "english" }));
            Console.WriteLine(GetLanguageInfo(new Language { Code = 2 }));
            Console.WriteLine(GetLanguageInfo(new Language { Name="German", Code = 3 }));
            Console.WriteLine(GetLanguageInfo(null));
        }
        // Паттерн свойств
        public static string GetMessage(Human human)
        {
            return human switch
            {
                { Age: 18 } => "Age 18",
                { Name: "Artyom" } => "Artyom, Age 18",
                { SurName: "Kolosov" } => "Artyom Kolosov, Age 18",
                { } => "Hello world"
            };
        }

        public static int GetOperationResult(int op, int n1, int n2) // паттерн switch С#8.0
        {
            return op switch
            {
                1 => n1 + n2,
                2 => n1 - n2,
                3 => n1 * n2,
                _ => throw new ArgumentException("This operation code doesn't exists!")
            };
        }

        // Паттерн кортежей
        public static string GetWelcome(string language, string dayTime, string status) => (language, dayTime, status) switch
        {
            ("english", "morning", _) => "Good morning!",
            (_, _, "sir") => "Hello, Sir!",
            ("german", _, _) => "Hello, German",
            _ => "Дарова!"
        };

        //Позиционный паттерн
        public static string GetLanguageInfo(Language language) => language switch
        {
            ("english",_) => "English Language",
            (_, 2) => "Russian language",
            (var name, var code) => $"Not found name {name}, code {code}",
            null => "null"
        };


    }
    class One
    {

    }
    class Two : One
    {
        public bool IsLegit { get; set; } = false;
    }
}
