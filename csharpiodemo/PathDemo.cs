using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class PathDemo
    {
        public static void Test()
        {
            Console.WriteLine(Path.Combine(@"f:\cs","1.txt"));
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.AltDirectorySeparatorChar);
        }
    }
}
