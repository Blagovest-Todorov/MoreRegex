using System;
using System.Text.RegularExpressions;

namespace RegularEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{2}([-\/])\w{3}\1[0-9]{4}";
            string text = @"13/Feb/2020 33-Jan-2020, 13/Feb-2020";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Groups[1].Value);
            }   
        }
    }
}
