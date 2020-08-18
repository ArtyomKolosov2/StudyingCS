using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine("Move method from PartialClass1.cs file");
                PartialMethod();
            }
        } 
    }
}
