using System;

namespace SelfCSharp.Chap05
{
    internal class StreamReadLine
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample.txt"))
            {
                while(!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
