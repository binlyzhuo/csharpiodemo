using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    //https://www.cnblogs.com/yy3b2007com/p/5558877.html
    //https://www.cnblogs.com/MRRAOBX/articles/6184722.html
    //https://www.cnblogs.com/Olive116/archive/2012/09/06/WinForm.html
    //https://blog.csdn.net/flyking2/article/details/78991774
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
                //newFile.Position = file.Position;
                bWriter.Write(bytes,0,data);
                newFile.Flush();
                //data++;
                num++;
                Console.WriteLine(num);
            }
        }
    }
}
