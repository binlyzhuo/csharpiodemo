using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class FileInfoDemo
    {
        public static void Test()
        {
            FileInfo file = new FileInfo(@"f:\cs\1.txt");
            Console.WriteLine("create date:"+file.CreationTime);
            Console.WriteLine(file.DirectoryName);
            StreamWriter sw = file.AppendText();
            sw.Write("ww");
            sw.WriteLine("xxx");

            //sw.Write("ww");
            sw.WriteLine("xxx");
            sw.Close();
            sw.Dispose();
        }
    }
}
