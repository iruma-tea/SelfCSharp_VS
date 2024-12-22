using System;

namespace SelfCSharp.Chap05
{
    internal class StreamWriteUsing
    {
        static void Main(string[] args)
        {
            using var writer = new StreamWriter(@"C:\Users\shusuke\source\repos\SelfCSharp\data\data.log");
            writer.WriteLine(DateTime.Now.ToString());
        }
    }
}
