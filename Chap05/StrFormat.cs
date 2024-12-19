using System;
using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class StrFormat
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0}は{1}、{2}歳です。", "サクラ", "女の子", 1));
            Console.WriteLine(string.Format("名前は{0}です。{0}は元気です。", "サクラ", "女の子"));
            Console.WriteLine(string.Format("名前は{0, 5}です。", "サクラ"));
            Console.WriteLine(string.Format("名前は{0, -5}です。", "サクラ"));
            Console.WriteLine(string.Format("10進数で8桁{0:d8}", 12345));
            Console.WriteLine(string.Format("指数{0:e2}", 12345));
            Console.WriteLine(string.Format("指数(大文字){0:E2}", 12345));
            Console.WriteLine(string.Format(new CultureInfo("da-DK"), "通貨(デンマーク):{0:C}", 12345));
        }
    }
}
