using System;

namespace SelfCSharp.Chap05
{
    internal class SpanBasic
    {
        static void Main(string[] args)
        {
            var list = new[] { 10, 20, 30, 40, 50, 60 };
            // int配列からSpanを生成
            var sp = new Span<int>(list, 2, 3);
            // Spanを列挙
            foreach(var v in sp)
            {
                Console.WriteLine(v);
            }
            // Span経由での更新
            sp[1] = 999;
            // int配列を列挙
            foreach(var v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}
