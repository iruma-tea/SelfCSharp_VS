﻿using System;

namespace SelfCSharp.Chap04
{
    internal class Continue
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += 1;
            }
            Console.WriteLine($"合計は{sum}です。");
        }
    }
}