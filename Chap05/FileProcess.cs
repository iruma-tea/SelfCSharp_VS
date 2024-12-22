using System;

namespace SelfCSharp.Chap05
{
    internal class FileProcess
    {
        static void Main(string[] args)
        {
            //FileInfoオブジェクトの生成(引数はファイルパス)
            var file = new FileInfo(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample.txt");

            // ファイルが存在するか?
            Console.WriteLine(file.Exists);
            // ファイル名を取得する
            Console.WriteLine(file.Name);
            // フォルダ名を取得
            Console.WriteLine(file.DirectoryName);
            // 読み取り専用か
            Console.WriteLine(file.IsReadOnly);
            // ファイルの最終アクセス日時、最終更新日時、サイズを取得
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Length);

            // ファイルのコピー
            var file2 = file.CopyTo(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample_copy.txt", true);
            // ファイルを移動
            file2.MoveTo(@"C:\Users\shusuke\source\repos\SelfCSharp\data\SelfCSharp\sample_copy.txt");
            // ファイル名を変更
            file2.MoveTo(@"C:\Users\shusuke\source\repos\SelfCSharp\data\SelfCSharp\sample_renamed.txt");
            // ファイルを削除
            file2.Delete();
        }
    }
}
