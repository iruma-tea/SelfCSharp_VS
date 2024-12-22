using System;

namespace SelfCSharp.Chap05
{
    internal class StreamRead
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
