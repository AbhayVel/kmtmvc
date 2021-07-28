using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRazerEngin
{
    public abstract class KmiWebViewPage<T>
    {

        public abstract void Execute();
        public T Model { get; set; }
        public string OutPut { get; set; }

       public void WriteLiteral(string text)
        {
            OutPut = OutPut + text;
        }

        public void Write(dynamic value)
        {
            OutPut = OutPut + value.ToString();
        }

        public override string ToString()
        {
            return OutPut; 
        }
    }
}