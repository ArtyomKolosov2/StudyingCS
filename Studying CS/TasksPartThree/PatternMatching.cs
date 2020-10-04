using Studying_CS.IOservices;
using System;
using TasksPartThree.StudyDeconstruction;

namespace TasksPartThree.StudyPatternMacthing
{
    public static class PatternMatching
    {
        public static void StartExample()
        {
            One first = new Two() { IsLegit = true };
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
                    ConsoleIOService.ShowUserStringWithLineBreak("NoPattern");
                    break;

            }
            ConsoleIOService.ShowUserStringWithLineBreak(GetMessage(new Human { Age = 18 }));
            ConsoleIOService.ShowUserStringWithLineBreak(GetMessage(new Human { Name = "Artyom" }));
            ConsoleIOService.ShowUserStringWithLineBreak(GetMessage(new Human { SurName = "Kolosov" }));
            ConsoleIOService.ShowUserStringWithLineBreak(GetMessage(new Human()));

            ConsoleIOService.ShowUserStringWithLineBreak(GetOperationResult(1, 2, 2));
            try
            {
                ConsoleIOService.ShowUserStringWithLineBreak(GetOperationResult(5, 2, 2));
            }
            catch (ArgumentException ex)
            {
                ConsoleIOService.ShowUserStringWithLineBreak(ex.Message);
            }
            ConsoleIOService.ShowUserStringWithLineBreak(GetWelcome("english", null, null));
            ConsoleIOService.ShowUserStringWithLineBreak(GetWelcome("rs", "morning", "sir"));

            ConsoleIOService.ShowUserStringWithLineBreak(GetLanguageInfo(new Language { Name = "english" }));
            ConsoleIOService.ShowUserStringWithLineBreak(GetLanguageInfo(new Language { Code = 2 }));
            ConsoleIOService.ShowUserStringWithLineBreak(GetLanguageInfo(new Language { Name = "German", Code = 3 }));
            ConsoleIOService.ShowUserStringWithLineBreak(GetLanguageInfo(null));
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
            ("english", _) => "English Language",
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
