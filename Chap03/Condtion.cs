﻿using System;

namespace SelfCSharp.Chap03
{
    internal class Condtion
    {
        static void Main(string[] args)
        {
            var score = 75;
            Console.WriteLine(score >= 70 ? "合格！" : "不合格...");
        }
    }
}
