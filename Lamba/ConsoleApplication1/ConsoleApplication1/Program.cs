﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"a","a1" },
                {"b","b1" }
            };

            string a = "c1";

            a =dictionary.Keys.Aggregate(a, (current, s) => current + dictionary[s]);

            Console.WriteLine(a);

            Console.Read();

        }
    }
}
