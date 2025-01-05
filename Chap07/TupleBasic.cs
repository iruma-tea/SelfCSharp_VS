namespace SelfCSharp.Chap07
{
    internal class TupleBasic
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
        }
        static void Main(string[] args)
        {
            var a = new TupleBasic();
            var t = a.GetMaxMin(15, 13);
            Console.WriteLine(t.max);
            Console.WriteLine(t.min);

            var (resultMax, resultMin) = a.GetMaxMin(5, 3);
            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
        }
    }
}
