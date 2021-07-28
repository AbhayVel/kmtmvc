using ConsoleAppFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample_First.Models
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public int Age { get; set; }


        //public override string ToString()
        //{
        //  var strArray=  Utility.FileReadLines(@"D:\kmi\First\ConsoleAppFirst\HTMLPage1.html");
        //  var output=   Utility.ReplaceValueFromObject(strArray, this);

        //    var str = "";
        //    foreach(var s in output)
        //    {
        //        str += s;
        //    }

        //    return str;
        //}
    }
}