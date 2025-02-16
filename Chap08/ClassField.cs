using System;

namespace SelfCSharp.Chap08.PublicField
{
    internal class Triangle
    {
        public double width; // 底辺
        public double height; // 高さ

        public double GetArea()
        {
            return this.width * this.height / 2;
        }
    }
    internal class ClassField
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.width = 10;
            t.height = 5;
            Console.WriteLine(t.GetArea());
        }
    }
}
