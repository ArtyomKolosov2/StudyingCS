using System;

namespace TasksPartThree.StudyDeconstruction
{
    public static class Deconstruction
    {
        public static void StartExample()
        {
            Language exLang = new Language { Code = 1, Name = "English" };
            (string langName, int langCode) = exLang;
            Console.WriteLine($"Name = {langName}, code = {langCode}");
            Human exHuman = new Human { Age = 18, Name = "Artyom", SurName = "Kolosov" };
            Human exHuman2 = new Human { Age = 20, Name = "Ad", SurName = "Kol" };
            exHuman.Deconstruct(out int age, out string name, out string surName);
            (int age2, string name2, _) = exHuman2;
            Console.WriteLine($"Age = {age}, Name = {name}, SurName = {surName}");
            Console.WriteLine($"Age = {age2}, Name = {name2}");
        }
    }

    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public void Deconstruct(out int age, out string name, out string surName)
        {
            age = Age;
            name = Name;
            surName = SurName;
        }
    }

    public class Language
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public void Deconstruct(out string name, out int code)
        {
            name = Name;
            code = Code;
        }
    }
}
