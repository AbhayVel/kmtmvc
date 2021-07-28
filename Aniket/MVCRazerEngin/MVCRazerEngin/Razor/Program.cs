using MVCRazerEngin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razor
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\kmi\Aniket\MVCRazerEngin\MVCRazerEngin\MVCRazerEngin\Views\Home\Home";
          //  CustomRazor.GeneratedCSfile();

            string writeData = CustomRazor.GeneratedCSfile(path + ".cshtml");

            bool isWrite = ReadWriteFileOperation.FileWriteAllLines(path + ".generated.cs", writeData, "Home", "Index");
        }
    }
}
