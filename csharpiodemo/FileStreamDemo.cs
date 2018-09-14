﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
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


    }
}
