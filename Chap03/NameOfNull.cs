using System;

namespace SelfCSharp.Chap03
{
    internal class NameOfNull
    {
        public void Hoge(string? str)
        {
            if (str == null)
            {
                //throw new ArgumentException("str");
                throw new ArgumentException(nameof(str));
            }
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            var nc = new NameOfNull();
            nc.Hoge(null);
        }
    }
}
