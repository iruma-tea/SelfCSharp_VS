using System;

namespace SelfCSharp.Chap07.Construct
{
    internal class Message
    {
        int number;

        // 静的コンストラクタ
        static Message()
        {
            Console.WriteLine("静的コンストラクタ");
        }

        // 通常のコンストラクタ
        public Message(int number)
        {
            this.number = number;
            Console.WriteLine($"通常のコンストラクタ{number}");
        }
    }
    internal class ConstructorStatic
    {
        static void Main(string[] args)
        {
            var m1 = new Message(1);
            var m2 = new Message(2);
        }
    }
}
