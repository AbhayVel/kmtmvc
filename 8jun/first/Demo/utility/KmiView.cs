using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.utility
{
    public class KmiView<T> : IKmiView where T: class
    {

        public string  FileName { get; set; }

        public string Output { get; set; }
        public KmiView(T model, string fileName)
        {
            Model = model;
            FileName = fileName;
        }
        public T Model { get; set; }
        public override string ToString()
        {

            //string Output = System.IO.File.ReadAllText(@"D:\kmi\8jun\first\Demo\Home_Index.html");
            

            return Output;
        }

        public void Execute()
        {
            Output = System.IO.File.ReadAllText(FileName);


            foreach (var key in Model.GetType().GetProperties())
            {

                string str = "@Model." + key.Name;
                var obj = key.GetValue(Model);
                string strValue = obj == null ? "" : obj.ToString();

                Output = Output.Replace(str, strValue);
            }
        }
    }
}