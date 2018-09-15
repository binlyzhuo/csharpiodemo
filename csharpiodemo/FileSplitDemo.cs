using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class FileSplitDemo
    {
        public static void Split()
        {
            string path = @"F:\cs\狄仁杰之四大天王.mkv";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] bytes = new byte[1024*1024];
            StreamReader reader = new StreamReader(file);
            int count = 1000;
            FileStream newFile = new FileStream(@"f:\cs\6.mkv", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(newFile);

            int data = 0;
            int num = 0;
            BinaryWriter bWriter = new BinaryWriter(newFile, Encoding.Default);

            
            while ((data=file.Read(bytes,0,bytes.Length))>0)
            {
                bWriter.Write(bytes,0,data);
                //data++;
                num++;
                Console.WriteLine(num);
            }
        }
    }
}
