using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    //https://www.cnblogs.com/wywnet/p/5249523.html
    public class FileStreamDemo
    {
        public static void Test()
        {
            string path = @"F:\cs\IOss.cs";
            byte[] b = File.ReadAllBytes(path);
            Console.WriteLine("读取二进制：");
            foreach (var b1 in b)
            {
                Console.Write((char)b1);
            }

            string[] s = File.ReadAllLines(path, Encoding.UTF8);
            foreach (var s1 in s)
            {
                Console.WriteLine("行:"+s1);
            }

            string allTxt = File.ReadAllText(path);
            Console.WriteLine("AllTxt:");
            Console.WriteLine(allTxt);
        }

        public static void WriteTxt()
        {
            string path = @"F:\cs\2.txt";
            File.WriteAllBytes(path,new byte[]{65,97});
            string[] arr = new string[]{"65","97"};
            File.WriteAllLines(path,arr,Encoding.UTF8);
            File.WriteAllText(path,"HelloWorld~",Encoding.UTF8);
        }

        public static void StreamWrite()
        {
            string path = @"F:\cs\3.txt";
            FileStream file = new FileStream(path,FileMode.Create,FileAccess.Write);
            string str = "test txt!";
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            file.Write(bytes,0,bytes.Length);
            file.Dispose();
            Console.WriteLine("write success");
            //Console.ReadLine();

            file = new FileStream(path,FileMode.Open,FileAccess.Read);
            file.Position = 0;
            byte[] temp = new byte[bytes.Length];
            file.Read(temp, 0, temp.Length);
            Console.WriteLine("read data:"+Encoding.UTF8.GetString(temp));
            file.Dispose();
            //Console.ReadLine();
        }

        public static void CopyTxtContent()
        {
            string path1 = @"f:\cs\IOss.cs";
            string path2 = @"f:\cs\oop.cs";
            using (FileStream fsRead = new FileStream(path1, FileMode.Open))
            {
                using (FileStream fsWrite = new FileStream(path2,FileMode.Append))
                {
                    byte[] arr = new byte[1024];
                    int count = 0;
                    while (fsRead.Position<fsRead.Length)
                    {
                        count = fsRead.Read(arr, 0, arr.Length);
                        fsWrite.Write(arr,0,count);
                    }
                }
            }
        }
    }
}
