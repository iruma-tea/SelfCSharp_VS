namespace SelfCSharp.Chap07
{
    internal class AnonymousBasic
    {
        static void Main(string[] args)
        {
            var info = new { Title = "速習C#", Price = 1000 };
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Price);
        }
    }
}
