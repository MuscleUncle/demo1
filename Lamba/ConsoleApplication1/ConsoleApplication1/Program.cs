using System;
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
                {"b","b1" },
                {"e","e1" },
                {"c","c1" }
            };

            string a = "d1";

            a = dictionary.Keys.Aggregate(a, (current, s) => current + dictionary[s]);

            Console.WriteLine(a);

            SayHello();

            Console.Read();

        }

        public static void SayHello()
        {
            Console.WriteLine("PPAP - Hello World!!");
        }
    }
}
