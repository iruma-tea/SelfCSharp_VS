﻿namespace SelfCSharp.Chap07
{
    internal class MySingleton
    {
        private static MySingleton instance = new MySingleton();
        private MySingleton() { }
        public static MySingleton Instance
        {
            get { return instance; }
        }

        static void Main(string[] args)
        {
            var ms1 = MySingleton.instance;
            var ms2 = MySingleton.instance;
            Console.WriteLine(ms1 == ms2);
        }
    }
}
