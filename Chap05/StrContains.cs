using System;

namespace SelfCSharp.Chap05
{
    internal class StrContains
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト";

            Console.WriteLine(str.Contains("プロ"));
            Console.WriteLine(str.StartsWith("WINGS"));
            Console.WriteLine(str.EndsWith("WINGS"));
        }
    }
}
