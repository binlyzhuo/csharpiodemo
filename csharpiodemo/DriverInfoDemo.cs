using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class DriverInfoDemo
    {
        public static void Test()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var info in drives)
            {
                if (info.IsReady)
                {
                    Console.WriteLine("总容量:{0}",info.TotalFreeSpace);
                    Console.WriteLine("可用容量:{0}",info.AvailableFreeSpace);
                    Console.WriteLine("驱动器类型:{0}",info.DriveFormat);
                    Console.WriteLine("驱动器名称:{0}\n",info.Name);
                }
            }
        }
    }
}
