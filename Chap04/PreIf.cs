#define DEBUG
using System;

namespace SelfCSharp.Chap04
{
    internal class PreIf
    {
        static void Main(string[] args)
        {
            // ...中略...
#if DEBUG
            Console.WriteLine("デバック時だけ表示します。");
#endif
        }
    }
}
