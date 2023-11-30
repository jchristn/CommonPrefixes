using System;
using System.Collections.Generic;
using CommonPrefixes;

namespace Test
{
    public static class Program
    {
        public static List<string> _Values1 = new List<string>
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

        public static List<string> _Values2 = new List<string>
        {
            "::foo::",
            "::foo::file1",
            "::foo::file2",
            "::foo::bar::",
            "::foo::bar::file1",
            "::foo::bar::file2",
            "bar",
            "::baz::",
            "::baz::file1",
            "::baz::file2",
            "::foo::bar::barbar::file1",
            "::foo::bar::barbar::file2"
        };

        public static void Main(string[] args)
        {
            List<string> prefixes;

            Console.WriteLine("");
            Console.WriteLine("Find by character");
            prefixes = PrefixesFinder.Find(_Values1, '/');
            if (prefixes != null)
            {
                foreach (string prefix in prefixes)
                {
                    Console.WriteLine(prefix);
                }

                Console.WriteLine("");
                Console.WriteLine(prefixes.Count + " common prefixes found");
            }

            Console.WriteLine("");
            Console.WriteLine("Find by string");
            prefixes = PrefixesFinder.Find(_Values2, "::");
            if (prefixes != null)
            {
                foreach (string prefix in prefixes)
                {
                    Console.WriteLine(prefix);
                }

                Console.WriteLine("");
                Console.WriteLine(prefixes.Count + " common prefixes found");

                Console.WriteLine("");
            }
        }
    }
}