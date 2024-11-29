using System;

namespace SelfCSharp.Chap05
{
    internal class StrLength
    {
        static void Main(string[] args)
        {
            var str1 = "ＷＩＮＧＳプロジェクト";
            Console.WriteLine(str1.Length);

            var str2 = "𠮟る";
            Console.WriteLine(str2.Length);
        }
    }
}
