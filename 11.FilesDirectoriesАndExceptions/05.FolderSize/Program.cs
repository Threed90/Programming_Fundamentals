using System;
using System.IO;
using System.Linq;

namespace _05.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = Directory.GetFiles(@"D:\Programming\C# programming fundamentals\11.FilesDirectoriesАndExceptions\05.FolderSize\05. Folder Size\TestFolder")
                                  .Select(e => new FileInfo(e).Length)
                                  .Sum();

            //int sum = 0;

            //foreach (var path in paths) //if there is string[] paths
            //{
            //    sum += (int)new FileInfo(path).Length;
            //}

            File.AppendAllText(@"..\..\..\output.txt", $"{sum / 1024 / 1024}");
        }
    }
}
