﻿using System;
using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegMatch
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            var match = rgx.Match(str);
            
            // マッチした場合のみ出力処理
            if (match.Success)
            {
                Console.WriteLine($"位置：{match.Index} マッチ文字列：{match.Value}");

                // サブマッチ文字列を順に出力
                foreach (Group m in match.Groups)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}
