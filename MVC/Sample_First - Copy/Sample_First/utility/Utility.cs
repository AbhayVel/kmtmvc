using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{

   public delegate string GetPropValue(PropertyInfo p, Object o, string name);
   public class Utility
    {




        public static string[] ReplaceValueFromObject(string[] strArr, dynamic e)
        {
            GetPropValue getValue = (p, x, y) => p.GetValue(x, null).ToString();


            for (var p = 0; p < strArr.Length; p++)
            {
                foreach (PropertyInfo pro in e.GetType().GetProperties())
                {
                    var key = "**{" + pro.Name + "}**";
                    strArr[p] = strArr[p].Replace(key, getValue(pro,e,""));
                }

            }

            return strArr;
        }

        public static string[] FileReadLines(string path)
        {
            string[] strArr = { };

            if (!System.IO.File.Exists(path))
            {
                return strArr;
            }
            try
            {
                strArr = System.IO.File.ReadAllLines(path);
            }
            catch (PathTooLongException)
            {

            }
            catch (IOException)
            {

            }
            catch(Exception)
            {

            }
           
            return strArr;
        }


        public static bool FileWriteLines(string path, string[] strArr)
        {
            try
            {
                StreamWriter file = new StreamWriter(path, append: false);

                foreach (var f in strArr)
                {
                    file.WriteLine(f);
                }

                file.Close();
            }
            catch(FileNotFoundException f)
            {
                return false;
            }
            catch(IOException ix)
            {
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            


            return true;
        }
    }
}
