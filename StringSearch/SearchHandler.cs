using System;

namespace StringSearch
{
    class SearchHandler
    {
        public EventHandler<StringFoundArgs> onStringFound = (sender, EventArgs) =>
        {
            Console.WriteLine(EventArgs.FoundString);
            EventArgs.CancelRequested = true;
        };
    }
}
