using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Reflection;

namespace MVCRazerEngin
{
    public class ReadWriteFileOperation
    {
        public static string FileReadLines(string path)
        {
            string strArr = "";
            try
            {
                //strArr = System.IO.File.ReadAllLines(path);
                strArr = System.IO.File.ReadAllText(path);
            }
            catch (ArgumentException ei)
            {
                Console.WriteLine(ei);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return strArr;
        }
        public static bool FileWriteAllLines(string path, string strArr,string contrl,string actin)
        {
            StreamWriter file = new StreamWriter(path, append: false);
            string classDetails = "public partial class _Views_" + contrl + "_" + actin + "_cshtml : System.Web.Mvc.WebViewPage<MVCRazerEngin.Models.Employee> { public _Views_" + contrl + "_" + actin + "_cshtml()      {         } public override void Execute()     { ";
            string finalstring = classDetails + strArr;
            finalstring = finalstring.Replace("\n", "").Replace("\r", "").Replace(");", ");\n").Replace("{", "\n{\n").Replace("}", "\n}\n");
            foreach (char f in finalstring)
            {
                file.Write(f);
            }
            file.WriteLine("}\n}");
            file.Close();
            return true;
        }
    }
}