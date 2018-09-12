using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class DirectoryDemo
    {
        public static void Test()
        {
            DirectoryInfo dir = new DirectoryInfo(@"f:\cs\1");
            dir.Create();
            Console.WriteLine("parent:"+dir.Parent.FullName);
            Console.WriteLine("===============");

            // 返回文件以及文件夹信息
            var files = dir.Parent.GetFileSystemInfos();
            foreach (var file in files)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
