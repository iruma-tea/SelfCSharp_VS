using System;

namespace SelfCSharp.Chap05
{
    internal class SpanString
    {
        static void Main(string[] args)
        {
            var str = "ＷＩＮＧＳプロジェクト";
            var sp = str.AsSpan(5, 5);
            //sp[2] = 'ゴ'; // エラー
        }
    }
}
