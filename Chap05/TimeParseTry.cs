using System;

namespace SelfCSharp.Chap05
{
    internal class TimeParseTry
    {
        static void Main(string[] args)
        {
            DateTime dt;
            if (DateTime.TryParse("2022/02/15 13:17:23", out dt))
            {
                Console.WriteLine(dt);
            }
        }
    }
}
