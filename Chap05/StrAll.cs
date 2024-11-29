using System;

namespace SelfCSharp.Chap05
{
    internal class StrAll
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト2号";
            Console.WriteLine(str.All(ch => Char.IsDigit(ch)));
        }
    }
}
