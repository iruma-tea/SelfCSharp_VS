﻿using System;

namespace SelfCSharp.Chap04.Practice
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;

            while(i <= 1000)
            {
                sum += i;
                if (sum > 1000)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine($"合計値が1000を超えるのは、1～{i}を加算したときです。");
        }
    }
}
