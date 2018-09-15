using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class StreamOffsetDemo
    {
        public static void Demo()
        {
            string txt = "百度知道";
            string path = @"f:\cs\12.txt";
            byte[] bytes = Encoding.UTF8.GetBytes(txt);
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate);
            fs.Write(bytes,0,bytes.Length);
            fs.Close();
            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write(txt);
            //sw.Close();

            fs = new FileStream(path,FileMode.Open);
            byte[] readBytes = new byte[100];
            fs.Read(readBytes, 0, readBytes.Length);
            string readTxt = Encoding.UTF8.GetString(readBytes,0,readBytes.Length);
            Console.WriteLine(readTxt);
        }
    }
}
