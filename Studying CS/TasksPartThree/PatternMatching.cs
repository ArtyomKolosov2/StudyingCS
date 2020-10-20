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
                    IOService.ShowUserStringWithLineBreak("NoPattern");
                    break;

            }
            IOService.ShowUserStringWithLineBreak(GetMessage(new Human { Age = 18 }));
            IOService.ShowUserStringWithLineBreak(GetMessage(new Human { Name = "Artyom" }));
            IOService.ShowUserStringWithLineBreak(GetMessage(new Human { SurName = "Kolosov" }));
            IOService.ShowUserStringWithLineBreak(GetMessage(new Human()));

            IOService.ShowUserStringWithLineBreak(GetOperationResult(1, 2, 2));
            try
            {
                IOService.ShowUserStringWithLineBreak(GetOperationResult(5, 2, 2));
            }
            catch (ArgumentException ex)
            {
                IOService.ShowUserStringWithLineBreak(ex.Message);
            }
            IOService.ShowUserStringWithLineBreak(GetWelcome("english", null, null));
            IOService.ShowUserStringWithLineBreak(GetWelcome("rs", "morning", "sir"));

            IOService.ShowUserStringWithLineBreak(GetLanguageInfo(new Language { Name = "english" }));
            IOService.ShowUserStringWithLineBreak(GetLanguageInfo(new Language { Code = 2 }));
            IOService.ShowUserStringWithLineBreak(GetLanguageInfo(new Language { Name = "German", Code = 3 }));
            IOService.ShowUserStringWithLineBreak(GetLanguageInfo(null));
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
