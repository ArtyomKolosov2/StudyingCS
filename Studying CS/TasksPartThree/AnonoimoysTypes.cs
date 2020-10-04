using Studying_CS.IOservices;

namespace TasksPartThree.StudyAnonymous
{
    public static class AnonoimoysTypes
    {
        public static void StartExample()
        {
            SimpleClass simple = new SimpleClass { SomeNumber = 100 };
            var type1 = new { Name = "Artyom", Age = 18 };
            var type2 = new { Name = "Ilya", Age = 223 };
            var type3 = new { Name = "Bill", Surname = "Geits", Company = "Microsoft" };
            var type4 = new { simple.SomeNumber };
            ConsoleIOService.ShowUserStringWithLineBreak($"{type1.GetType()} == {type1.GetType()} = {type1.GetType() == type2.GetType()}");
            ConsoleIOService.ShowUserStringWithLineBreak($"Type3 = {type3.GetType()}");
            ConsoleIOService.ShowUserStringWithLineBreak($"Type4 = {type4.GetType()}");
        }
    }
    public class SimpleClass
    {
        public int SomeNumber { get; set; }
    }
}
