using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    namespace OversRiders
    {
        public class BaseClassOver
        {
            protected virtual int Num { get; set; }

            public virtual void Show()
            {
                Console.WriteLine("BaseClassShow Num = {0}", Num.ToString());
            }
        }

        public sealed class NewClassOver : BaseClassOver
        {
            private int num;
            protected override int Num
            {
                get { return num; }
                set { if (value > 100) num = value; }
            }

            public override void Show()
            {
                Console.WriteLine("NewClassShow Num = {0}", Num.ToString());
            }
        }
    }
    namespace Shadowing
    {
        public class BaseEx 
        {
            public string Name { get; set; } = "Artyom";
            public readonly int age = 18;

            public BaseEx(string name)
            {
                Name = name;
            }
            public void Show()
            {
                Console.WriteLine("BaseEx show name = {0}, age = {1}", 
                    Name, 
                    age);
            }
        }

        public sealed class NewEx : BaseEx
        {
            private string SecondName { get; set; } = "Kolosov";
            public new readonly int age = 20;
            public NewEx(string name, string second_name) : base(name)
            {
                SecondName = second_name;
            }

            public new void Show()
            {
                Console.WriteLine("NewEx show name = {0}, second name = {1}, age = {2}", 
                    Name, 
                    SecondName, 
                    age.ToString()
                    );
            }
        }

    }
}
