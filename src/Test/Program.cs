using System;
using System.Collections.Generic;
using CommonPrefixes;

namespace Test
{
    public static class Program
    {
        public static List<string> _Values = new List<string>
        {
            "/foo/",
            "/foo/file1",
            "/foo/file2",
            "/foo/bar/",
            "/foo/bar/file1",
            "/foo/bar/file2",
            "bar",
            "/baz/",
            "/baz/file1",
            "/baz/file2",
            "/foo/bar/barbar/file1",
            "/foo/bar/barbar/file2"
        };
        public static void Main(string[] args)
        {
            List<string> prefixes = PrefixesFinder.Find(_Values, '/');
            if (prefixes != null)
            {
                foreach (string prefix in prefixes)
                {
                    Console.WriteLine(prefix);
                }

                Console.WriteLine("");
                Console.WriteLine(prefixes.Count + " common prefixes found");
            }
        }
    }
}