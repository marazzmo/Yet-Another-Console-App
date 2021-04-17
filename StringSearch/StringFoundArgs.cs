using System;

namespace StringSearch
{
    public class StringFoundArgs : EventArgs
    {
        public string FoundString { get; }
        public bool CancelRequested { get; set; }
        public StringFoundArgs(string str)
        {
            FoundString = str;
        }
    }
}
