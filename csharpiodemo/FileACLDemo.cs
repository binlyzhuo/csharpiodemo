using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace csharpiodemo
{
    public class FileACLDemo
    {
        public static void Demo()
        {
            string path = @"F:\cs\5.txt";
            FileStream file = new FileStream(path,FileMode.Open,FileAccess.Read);
            FileSecurity fileSec = file.GetAccessControl();
            foreach (FileSystemAccessRule fileRule in fileSec.GetAccessRules(true,true,typeof(NTAccount)))
            {
                Console.WriteLine(fileRule.AccessControlType+"-"+fileRule.FileSystemRights+"-"+fileRule.IdentityReference);
            }

            file.Dispose();

        }
    }
}
