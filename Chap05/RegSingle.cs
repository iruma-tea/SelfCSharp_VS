﻿using System;
using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegSingle
    {
        static void Main(string[] args)
        {
            var str = "初めして。\nよろしくお願いします。";
            var rgx = new Regex(@"^.+", RegexOptions.Singleline);
            var result = rgx.Matches(str);

            foreach(Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
