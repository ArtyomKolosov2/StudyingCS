using Studying_CS.IOservices;
using System;
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
            IOService.ShowUserStringWithLineBreak(typeof(MyType));
            IOService.ShowUserStringWithLineBreak(Type.GetType("Studying_CS.Reflection.MyType", true, false));
            IOService.ShowUserStringWithLineBreak(testInstance.GetType());
            Type myType = testInstance.GetType();
            MemberInfo[] members = myType.GetMembers();

            Program.print_splitter(amount, splitter);
            foreach (var member in members)
            {
                IOService.ShowUserStringWithLineBreak($"Memeber = {member.DeclaringType}, {member.MemberType}, {member.Name}");
            }
            Program.print_splitter(amount, splitter);
            var fields = myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var field in fields)
            {
                IOService.ShowUserStringWithLineBreak($"Field = {field?.Name}, Type = {field.FieldType.Name}, Value = {field.GetValue(testInstance)?.ToString()}");
            }
            Program.print_splitter(amount, splitter);
            var methods = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var method in methods)
            {
                Console.Write($"{method.ReturnType} {method.Name}(");
                var parametres = method.GetParameters();
                for (int i = 0; i < parametres.Length; i++)
                {
                    Console.Write($"{parametres[i].ParameterType} {parametres[i].Name}");
                    if (i + 1 < parametres.Length)
                    {
                        Console.Write(',');
                    }
                }
                Console.Write(")\n");
            }
            Program.print_splitter(amount, splitter);
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\User\source\repos\Studying CS\Studying CS\Reflection\TestAssembly.dll");
            IOService.ShowUserStringWithLineBreak(assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                IOService.ShowUserStringWithLineBreak(type);
            }
            Type programType = assembly.GetType("TestAssembly.Program");
            object pr = Activator.CreateInstance(programType);
            MethodInfo methodInfo = programType.GetMethod("DoSmt2");
            methodInfo?.Invoke(pr, null);

            Assembly thAsm = Assembly.LoadFrom(@"C:\Users\User\source\repos\Studying CS\Studying CS\Reflection\TestThreadAsm.dll");
            IOService.ShowUserStringWithLineBreak(thAsm.FullName);
            Type thType = thAsm.GetType("UrokiSS.Program");
            object type1 = Activator.CreateInstance(thType);
            MethodInfo main = thType.GetMethod("Main", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
            main?.Invoke(type1, new object[] { new string[] { } });
        }
    }
}
