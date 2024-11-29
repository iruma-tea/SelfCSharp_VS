using System;

namespace SelfCSharp.Chap04
{
    internal class Goto
    {
        static void Main(string[] args)
        {
            goto THERE;
            Console.WriteLine("ここはスキップされる");

        THERE:
            Console.WriteLine("コードが終了しました。");
        }
    }
}
