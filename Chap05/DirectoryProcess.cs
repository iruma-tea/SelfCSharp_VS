using System;

namespace SelfCSharp.Chap05
{
    internal class DirectoryProcess
    {
        static void Main(string[] args)
        {
            var dir = new DirectoryInfo(@"C:\Users\shusuke\source\repos\SelfCSharp");

            // フォルダーが存在するか
            Console.WriteLine(dir.Exists);
            // フォルダーの親フォルダーを取得
            Console.WriteLine(dir.Parent);
            // フォルダーのルートを取得
            Console.WriteLine(dir.Root);
            // ファイルの作成日時、最終アクセス日時、最終更新日時を取得
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.LastWriteTime);

            // サブフォルダーの一覧を取得
            var dirs = dir.GetDirectories();
            foreach(var d in dirs)
            {
                Console.WriteLine(d.FullName);
            }

            // フォルダーの作成
            var dir2 = new DirectoryInfo(@"C:\Users\shusuke\source\repos\SelfCSharp\smp");
            dir2.Create();

            // フォルダー名の変更
            dir2.MoveTo(@"C:\Users\shusuke\source\repos\SelfCSharp\test");
            // フォルダーの移動
            dir2.MoveTo(@"C:\Users\shusuke\source\repos\SelfCSharp\data\test");

            // サブフォルダーの作成
            dir2.CreateSubdirectory("sub");

            // フォルダーの削除
            dir2.Delete(true);
        }
    }
}
