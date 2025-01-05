namespace SelfCSharp.Chap07.Finalize
{
    internal class MyProcess
    {
        // コンストラクタ
        public MyProcess()
        {
            Console.WriteLine("Constructor");
        }

        // ファイナライザー
        ~MyProcess()
        {
            Console.WriteLine("finalizer");
        }
    }
    internal class FinalizeBasic
    {
        static void Main(string[] args)
        {
            var mp = new MyProcess();
        }
    }
}
