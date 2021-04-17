using System;
using System.Collections.Generic;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<string>();
            l.Add("cafnuka");
            l.Add("anfuka");
            l.Add("asfuks");

            try
            {
                var ss = new StringSearcher();
                var sh = new SearchHandler();

                ss.StringFound += sh.onStringFound;

                ss.StringSearch(l, "fu");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
