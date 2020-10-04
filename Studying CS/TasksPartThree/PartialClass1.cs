using Studying_CS.IOservices;

namespace TasksPartThree
{
    namespace StudyPartial
    {
        public static class StartPartial
        {
            public static void StartExample()
            {
                PartialClass1.Move();
                PartialClass1.Drive();
            }
        }
        static partial class PartialClass1
        {
            static partial void PartialMethod();
            public static void Move()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Move method from PartialClass1.cs file");
                PartialMethod();
            }
        }
    }
}
