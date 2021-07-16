using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05_Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();
            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);

            foreach (var item in files)
            {
                FileInfo info = new FileInfo(item);
                string extentoin = info.Extension;

                if (!filesByExtension.ContainsKey(extentoin))
                {
                    filesByExtension.Add(extentoin, new List<FileInfo>());
                }

                filesByExtension[extentoin].Add(info);
            }

            using (StreamWriter writer = new StreamWriter(Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var item in filesByExtension
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var info in item.Value
                        .OrderBy(x => Math.Ceiling((double)x.Length / 1024)))
                    {
                        writer.WriteLine($"--{info.Name} - {Math.Ceiling((double)info.Length / 1024)}kb");
                    }
                }
            }

        }
    }
}
