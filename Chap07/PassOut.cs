namespace SelfCSharp.Chap07
{
    internal class PassOut
    {
        public void GetMaxMin(int x, int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }

        static void Main(string[] args)
        {
            var a = new PassOut();
            int resutMax, resultMin;
            a.GetMaxMin(5, 2, out resutMax, out resultMin);
            Console.WriteLine(resutMax);
            Console.WriteLine(resultMin);
        }
    }
}
