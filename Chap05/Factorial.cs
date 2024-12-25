using System;

namespace SelfCSharp.Chap05
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            long result = 1;
            for (var i = 1; i < 26; i++)
            {
                // 1 ～ 25の値を順に乗算
                result *= i;
                Console.WriteLine(result);
            }
        }
    }
}
