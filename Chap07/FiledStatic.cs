namespace SelfCSharp.Chap07
{
    internal class MyApp
    {
        public static readonly string Title = "独習C#";
        //public const string Title = "独習C#";
    }
    internal class FiledStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyApp.Title);
            //MyApp.Title = "本気で覚えるC#";
        }
    }
}
