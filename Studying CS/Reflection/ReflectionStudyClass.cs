using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Studying_CS.Reflection
{
    public static class ReflectionStudyClass
    {
        public static void StartExample()
        {
            Console.WriteLine(typeof(MyType));
            Console.WriteLine(Type.GetType("", true, false)) ;
        }
    }
}
