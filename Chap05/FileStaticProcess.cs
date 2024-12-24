using System;

namespace SelfCSharp.Chap05
{
    public class FileStaticProcess
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample.txt"));
            Console.WriteLine(File.GetLastWriteTime(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample.txt"));
            // ファイルを上書き
            File.Copy(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample.txt", @"C:\Users\shusuke\source\repos\SelfCSharp\data\sample_copy.txt", true);
            // ファイルの移動
            File.Move(@"C:\Users\shusuke\source\repos\SelfCSharp\data\sample_copy.txt", @"C:\Users\shusuke\source\repos\SelfCSharp\data\SelfCSharp\sample_copy.txt");
            // ファイル名を変更
            File.Move(@"C:\Users\shusuke\source\repos\SelfCSharp\data\SelfCSharp\sample_copy.txt", @"C:\Users\shusuke\source\repos\SelfCSharp\data\SelfCSharp\sample_renamed.txt");
            // ファイルを削除
            File.Delete(@"C:\Users\shusuke\source\repos\SelfCSharp\data\SelfCSharp\sample_renamed.txt");
        }
    }
}
