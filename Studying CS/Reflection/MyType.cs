using Studying_CS.IOservices;
using System;

namespace Studying_CS.Reflection
{
    public interface IMyTextValue
    {
        string Text { get; set; }
    }

    public class MyTypeParent
    {
        public string ParentText { get; set; } = "ParentText";
    }
    public class MyType : MyTypeParent, IMyTextValue
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
            IOService.ShowUserStringWithLineBreak("DoSmt1");
            DoSmt1EventHandler?.Invoke("SmtHappend");
        }
        public void DoSmt2()
        {
            IOService.ShowUserStringWithLineBreak("DoSmt2");
        }

        private string DoSmt3()
        {
            IOService.ShowUserStringWithLineBreak("DoSmt3");
            return "SMT3";
        }
    }
}
