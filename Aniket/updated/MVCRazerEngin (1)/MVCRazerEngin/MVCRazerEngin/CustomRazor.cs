using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
namespace MVCRazerEngin
{
    public class CustomRazor
    {
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
                string str = ReadWriteFileOperation.FileReadLines(path);
                foreach (char i in str)
                {
                    cnt++;
                    if(cnt==115)
                    {
                        cnt = 115;
                    }
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
                        if (i == '@' || i == '}' )
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
                            if(i=='"')
                            {
                                strHTMLCode.Append('\\');
                            }
                            strHTMLCode.Append(i);
                            continue;
                        }
                    }
                    else
                    {
                        if (i == '<' || (i==')' && strCSCode[0]=='(' ))
                        {
                            char[] nextchar = str.ToCharArray(cnt, 1);
                            if (Char.IsLetter(nextchar[0]) || nextchar[0].Equals('/') || (i == ')' && strCSCode[0] == '('))
                            {
                                flag = true;
                                var s = strCSCode.ToString().Trim();
                                if (s.Contains('}') == false && s.Contains('{') == false || (i == ')' && strCSCode[0] == '('))
                                {
                                    if (i == ')' && strCSCode[0] == '(')
                                    {
                                        strCSCode.Remove(0,1);
                                    }
                                    if (strCSCode!=null)
                                    { 
                                        string emptystr=strCSCode.ToString().Trim();
                                        if (emptystr== "")
                                        {
                                            strCSCode.Clear();
                                            continue;
                                        }
                                    }
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
        public static bool generateNewFile(string cnt,string actn)
        {
            string path = @"c:\Users\CTHG3BS\Documents\Visual Studio 2013\Projects\MVCRazerEngin\MVCRazerEngin\Views\Home\Temp";
            string writeData = CustomRazor.GeneratedCSfile(path+".cshtml");

            bool isWrite = ReadWriteFileOperation.FileWriteAllLines(path+".generated.cs", writeData, cnt, actn);
            return isWrite;
        }
    }
}