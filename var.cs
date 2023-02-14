

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var domain = new Dictionary<string, string>()
            {
                {"est", "Estonia"},
                {"lat", "Latvia"},
                {"fin", "Finland"},
                {"swe", "Sweden"}
            };

            domain.ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}"));
        }
    }
}
