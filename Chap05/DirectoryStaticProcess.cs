using System;

namespace SelfCSharp.Chap05
{
    internal class DirectoryStaticProcess
    {
        static void Main(string[] args)
        {
            // フォルダーが存在するか
            Console.WriteLine(Directory.Exists(@"C:\Users\shusuke\source\repos\SelfCSharp"));
            // フォルダーの親フォルダーを取得
            Console.WriteLine(Directory.GetParent(@"C:\Users\shusuke\source\repos\SelfCSharp"));
            // フォルダーのルートを取得
            Console.WriteLine(Directory.GetDirectoryRoot(@"C:\Users\shusuke\source\repos\SelfCSharp"));
            // ファイルの作成日時、最終アクセス日時、最終更新日時を取得
            Console.WriteLine(Directory.GetCreationTime(@"C:\Users\shusuke\source\repos\SelfCSharp"));
            Console.WriteLine(Directory.GetLastAccessTime(@"C:\Users\shusuke\source\repos\SelfCSharp"));
            Console.WriteLine(Directory.GetLastWriteTime(@"C:\Users\shusuke\source\repos\SelfCSharp"));
            // サブフォルダーの一覧を表示
            var dirs = Directory.GetDirectories(@"C:\Users\shusuke\source\repos\SelfCSharp");
            foreach (var d in dirs)
            {
                Console.WriteLine(d);
            }
            // フォルダーの作成
            Directory.CreateDirectory(@"C:\Users\shusuke\source\repos\smp");
            // フォルダー名の変更
            Directory.Move(@"C:\Users\shusuke\source\repos\smp", @"C:\Users\shusuke\source\repos\test");
            // フォルダーの移動
            Directory.Move(@"C:\Users\shusuke\source\repos\test", @"C:\Users\shusuke\source\repos\SelfCSharp\test");
            // フォルダーの削除
            Directory.Delete(@"C:\Users\shusuke\source\repos\SelfCSharp\test");
        }
    }
}
