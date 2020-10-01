using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_CS.Reflection
{
    public class MyType
    {
        private int _someNumber;
        public string Text { get; set; }

        public delegate void DoSmt1Called(string text);

        public event DoSmt1Called DoSmt1EventHandler;
        public DateTime CreationTime { get; private set; } = DateTime.Now;
        
        public MyType()
        {
            _someNumber = 0;
            Text = "MyType standart";
        }

        public MyType(int num) : this("NoData")
        {
            _someNumber = num;
        }
        public MyType(string text)
        {
            Text = text;
        }
        private void DoSmt1()
        {
            Console.WriteLine("DoSmt1");
            DoSmt1EventHandler?.Invoke("SmtHappend");
        }
        public void DoSmt2()
        {
            Console.WriteLine("DoSmt2");
        }

        private string DoSmt3()
        {
            Console.WriteLine("DoSmt3");
            return "SMT3";
        }
    }
}
