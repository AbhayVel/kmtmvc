using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

namespace first
{
    public class CustomRazor
    {

        public static bool FileWriteAllLines(string path, string strArr, string contrl, string actin)
        {
            StreamWriter file = new StreamWriter(path, append: false);
            string classDetails = "public partial class _Views_" + contrl + "_" + actin + "_cshtml : System.Web.Mvc.WebViewPage<dynamic> { public _Views_" + contrl + "_" + actin + "_cshtml()      {         } public override void Execute()     { ";
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
        public static string GeneratedCSfile(string path)
        {
            StringBuilder Finaloutput = new StringBuilder("");
            StringBuilder strHTMLCode = new StringBuilder();
            StringBuilder strCSCode = new StringBuilder();
            int cnt = 0;
            bool isComment = false;
            bool flag = true; //true means literal false means cs code

            if (path != null)
            {
                string str = FileReadLines(path);
                foreach (char i in str)
                {
                    cnt++;
                    if (isComment==true)
                    {
                            char[] nextchar = str.ToCharArray(cnt, 1);
                            if (nextchar[0].Equals('@') && i == '*')
                            {
                                isComment = false;
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                    }
                    else if(flag)
                    {
                        if (i == '@' || i == '}')
                        {
                            char[] nextchar = str.ToCharArray(cnt, 1);
                            if (nextchar[0].Equals('*'))
                            {
                                isComment = true;
                                continue;
                            }
                            flag = false;
                            Finaloutput.Append("\nWriteLiteral(\"");
                            Finaloutput.Append(strHTMLCode);
                            Finaloutput.Append("\");\n");
                            strHTMLCode.Clear();
                            if (i == '}')
                            {
                                strCSCode.Append(i);
                                continue;
                            }
                            continue;
                        }
                        else
                        {
                            strHTMLCode.Append(i);
                            continue;
                        }
                    }
                    else
                    {
                        if (i == '<')
                        {
                            char[] nextchar = str.ToCharArray(cnt, 1);
                            if (Char.IsLetter(nextchar[0]) || nextchar[0].Equals('/'))
                            {
                                flag = true;
                                var s = strCSCode.ToString().Trim();
                                if (s.Contains('}') == false && s.Contains('{') == false)
                                {
                                    Finaloutput.Append("Write(");
                                    Finaloutput.Append(strCSCode);
                                    Finaloutput.Append(");");
                                    strCSCode.Clear();
                                    strHTMLCode.Append(i);
                                    continue;
                                }
                                Finaloutput.Append(strCSCode);
                                strCSCode.Clear();
                                strHTMLCode.Append(i);
                                continue;
                            }
                            else
                            {
                                strCSCode.Append(i);
                                continue;
                            }
                        }
                        else
                        {
                            strCSCode.Append(i);
                            continue;
                        }
                    }
                }
                if (flag == true)
                {
                    Finaloutput.Append("\nWriteLiteral(\"");
                    Finaloutput.Append(strHTMLCode);
                    Finaloutput.Append("\");\n");
                }
                if (flag == false)
                {
                    Finaloutput.Append(strCSCode);
                }
                Console.WriteLine(Finaloutput + "" + cnt);
            }
            return Finaloutput.ToString();
        }
        public static bool generateNewFile(string path, string cnt,string actn)
        {
           // string path = @"c:\Users\CTHG3BS\Documents\Visual Studio 2013\Projects\MVCRazerEngin\MVCRazerEngin\Views\Home\Temp";
            string writeData = CustomRazor.GeneratedCSfile(path);
            path = path.Replace(".html", ".generated.cs");
            bool isWrite = FileWriteAllLines(path, writeData, cnt, actn);
            return isWrite;
        }
    }
}