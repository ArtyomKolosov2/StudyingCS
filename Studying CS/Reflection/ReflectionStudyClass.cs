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
            int amount = 50;
            string splitter = "=";
            MyType testInstance = new MyType(100);
            Console.WriteLine(typeof(MyType));
            Console.WriteLine(Type.GetType("Studying_CS.Reflection.MyType", true, false)) ;
            Console.WriteLine(testInstance.GetType());
            Type myType = testInstance.GetType();
            MemberInfo[] members = myType.GetMembers();

            Program.print_splitter(amount, splitter);
            foreach (var member in members)
            {
                Console.WriteLine($"Memeber = {member.DeclaringType}, {member.MemberType}, {member.Name}");
            }
            Program.print_splitter(amount, splitter);
            var fields = myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var field in fields)
            {
                Console.WriteLine($"Field = {field?.Name}, Type = {field.FieldType.Name}, Value = {field.GetValue(testInstance)?.ToString()}");
            }
            Program.print_splitter(amount, splitter);

        }
    }
}
