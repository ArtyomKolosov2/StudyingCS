using System;
using System.Collections.Generic;
using System.Text;

namespace TasksPartThree
{
    namespace StudyPartial
    {
        static partial class PartialClass1
        {
            public static void Drive()
            {
                Console.WriteLine("Drive method from PartialClass2.cs file");
            }
            static partial void PartialMethod()
            {
                Console.WriteLine("Partial Methdo form PartialClass2.cs file");
            }
        } 
    }
}
