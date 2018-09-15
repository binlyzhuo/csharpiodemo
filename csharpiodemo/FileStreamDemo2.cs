using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class FileStreamDemo2
    {
        public static void Demo1()
        {
            string msg = "okffffffffffffffff";
            string path = @"f:\cs\10.txt";
            byte[] myBytes = Encoding.UTF8.GetBytes(msg);

            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate))
            {
                fsWrite.Write(myBytes,0,myBytes.Length);
            }

            using (FileStream fsRead = new FileStream(path,FileMode.Open))
            {
                int fsLen = (int)fsRead.Length;
                byte[] heByte = new byte[fsLen];
                int r = fsRead.Read(heByte, 0, heByte.Length);
                string myStr = Encoding.UTF8.GetString(heByte);
                Console.WriteLine(myStr);
            }
        }


    }
}
