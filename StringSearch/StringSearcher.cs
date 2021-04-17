using System;
using System.Collections.Generic;

namespace StringSearch
{
    public class StringSearcher
    {
        public event EventHandler<StringFoundArgs> StringFound;

        public void StringSearch(List<string> strings, string filter)
        {
            foreach (string str in strings)
            {
                if (str.Contains(filter))
                {
                    var args = new StringFoundArgs(str);
                    StringFound?.Invoke(this, args);
                    if (args.CancelRequested)
                    {
                        break;
                    }
                }
            }
        }
    }
}
