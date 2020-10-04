namespace Studying_CS.IOservices
{
    interface IOutputService
    {
        public void ShowStringWithoutLineBreak(string data);
        public void ShowStringWithoutLineBreak(object obj);
        public void ShowStringWithLineBreak();
    }
}
