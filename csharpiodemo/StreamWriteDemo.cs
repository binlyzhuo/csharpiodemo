using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class StreamWriteDemo
    {
        public static void Test()
        {
            string path = @"F:\cs\5.txt";
            FileStream file = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("write txt000000000");
            sw.Dispose();
            Console.WriteLine("Write Success!!");

            file = new FileStream(path,FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            Console.WriteLine("read data:"+sr.ReadToEnd());
            sr.Dispose();
            //Console.ReadLine();
        }
    }
}
