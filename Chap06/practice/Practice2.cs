using System;

namespace SelfCSharp.Chap06.practice
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["lettuce"] = "レタス",
                ["spinach"] = "ホウレンソウ",
                ["cucumber"] = "キュウリ"
            };
            dic["cucumber"] = "キュウリ";
            dic.Add("cabbage", "キャベツ");
            dic.Remove("spinach");
            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key} : {m.Value}");
            }
        }
    }
}
