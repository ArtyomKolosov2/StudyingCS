using Studying_CS.IOservices;

namespace TasksPartThree
{
    namespace StudyPartial
    {
        static partial class PartialClass1
        {
            public static void Drive()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Drive method from PartialClass2.cs file");
            }
            static partial void PartialMethod()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Partial Methdo form PartialClass2.cs file");
            }
        }
    }
}
