﻿using System;

namespace SelfCSharp.Chap07.MethodStatic
{
    internal class Figure
    {
        // クラスフィールドを定義
        public static double Pi = 3.14;

        public static void GetCircleArea(double r)
        {
            Console.WriteLine($"円の面積は{r * r * Pi}");
        }

        // クラスメソッドの定義
        public static void GetTriangleArea(int width, int height)
        {
            Console.WriteLine($"三角形の面積は{width * height / 2}");
        }
    }
    internal class StaticBasic
    {
        static void Main(string[] args)
        {
            // クラスメソッドの呼び出し
            Figure.GetTriangleArea(10, 20);
            Console.WriteLine(Figure.Pi);
            Figure.GetCircleArea(5);
        }
    }
}
