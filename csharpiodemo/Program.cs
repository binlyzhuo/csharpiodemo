﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    //https://www.cnblogs.com/liyangLife/p/4797583.html
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c# io demo!");
            FileInfoDemo.Test();
            DirectoryDemo.Test();
            PathDemo.Test();
            DriverInfoDemo.Test();
            //FileStreamDemo.Test();
            FileStreamDemo.WriteTxt();
            FileStreamDemo.StreamWrite();
            StreamWriteDemo.Test();
            //FileACLDemo.Demo();
            //FileSplitDemo.Split();
            FileStreamDemo.CopyTxtContent();
            FileStreamDemo2.Demo1();
            StreamOffsetDemo.Demo();
            Console.WriteLine("complete!");
            Console.ReadLine();
        }
    }
}
