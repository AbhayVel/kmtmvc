using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
//using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
  static  class Program
    {

        public delegate bool DCondition<T>(T i);

        public delegate bool DConditionString(string str);

        public static dynamic data;

        public static void Change(Employee e)
        {
            e = new Employee();
            e.Id = 100;

        }

        public static void Change(int i)
        {
            i = 12;
        }
        static void Main(string[] args)
        {

            int i = 0;
            Employee e = new Employee();

            e.Id = 12;
            e.Name = "Ajay";
            
        //    var i = 0;
            Change(i);
            Change(e);

            Console.WriteLine(i);
            Console.WriteLine(e.Id);

            Console.Read();
           

         
        }


        //public static int GetCount(ArrayList arr, DConditionString condition)
        //{
        //    var k = 0;
        //    var arrayLength = arr.Count - 1;
        //    for (int i = 0; i <= arrayLength; i = i + 1)
        //    {

        //        if (condition(arr[i]))
        //        {
        //            k++;
        //        }
        //    }
        //    return k;
        //}


        public static string CamelCase(this string str)
        {
            if (str==null || str.Length == 0)
            {
                return string.Empty;
            }
            if (str.Length == 1)
            {
                return str.ToUpper();
            }

            if(str.Contains(" "))
            {
                return str.Substring(0, 1).ToUpper() + str.Substring(1);
            }
            else
            {
                return str.Substring(0, 1).ToUpper() + str.Substring(1);
            }
            
        }
        public static int GetCount<T>(this IEnumerable<T> arr, DCondition<T> condition)
        {

            if (arr == null)
            {
                return 0;
            }
            var k = 0;
            
            foreach (var a in arr)
            {
                if (condition(a))
                {
                    k++;
                }
            }
            return k;
        }


        public static IEnumerable<T> GetList<T>(this IEnumerable<T> arr, DCondition<T> condition) //Extntion method for IEnumrble
        {
            List<T> list = new List<T>();
            if (arr == null)
            {
                return list;
            }
            var k = 0;
           // var arrayLength = arr. - 1;
            //for (int i = 0; i <= arrayLength; i = i + 1)
            //{
            
            foreach (var a in arr) {
                if (condition(a))
                {

                    list.Add(a);
                    k++;
                }
            }
           // }

            return list;
        }
        //    public static List<T> GetList<T>(T[] arr, DCondition<T> condition)
        //{

        //    List<T> list = new List<T>();
        //    var k = 0;
        //    var arrayLength = arr.Length - 1;
        //    for (int i = 0; i <= arrayLength; i = i + 1)
        //    {
        //        if (condition(arr[i]))
        //        {

        //            list.Add(arr[i]);
        //            k++;
        //        }
        //    }
        //    return list;
        //}


        //public static int GetCount<T>(T[] arr, DCondition<T> condition)
        //{
        //    var k = 0;
        //    var arrayLength = arr.Length - 1;
        //    for (int i = 0; i <= arrayLength; i = i + 1)
        //    {
        //        if (condition(arr[i]))
        //        {
        //            k++;
        //        }
        //    }
        //    return k;
        //}
        //public static int GetCount<T>(T[] arr, DCondition<T> condition)
        //{
        //    var k = 0;
        //    var arrayLength = arr.Length - 1;
        //    for (int i = 0; i <= arrayLength; i = i + 1)
        //    {
        //        if (condition(arr[i]))
        //        {
        //            k++;
        //        }
        //    }
        //    return k;
        //}

        public static int GetCount(int[] arr, int compare, string flag)
        {
            var k = 0;
            var arrayLength = arr.Length - 1;
            for (int i = 0; i <= arrayLength; i = i + 1)
            {
                if (flag.Equals("Geq"))
                {
                    if (arr[i] >= compare)
                    {
                        k++;
                    }
                } else if (flag.Equals("Leq"))
                {
                    if (arr[i] <= compare)
                    {
                        k++;
                    }
                }
                else if (flag.Equals("Mod"))
                {
                    if (arr[i] % compare==0)
                    {
                        k++;
                    }
                }
            }
            return k;

        }


        public static int GetCountGEQ(int[] arr,int compare)
        {
          var  k = 0;
          var  arrayLength = arr.Length - 1;
            for (int i = 0; i <= arrayLength; i = i + 1)
            {

                if (arr[i] >= compare)
                {
                    k++;
                }
            }

            return k;

        }


        public static int GetCountLEQ(int[] arr, int compare)
        {
            var k = 0;
            var arrayLength = arr.Length - 1;
            for (int i = 0; i <= arrayLength; i = i + 1)
            {
                if (arr[i] <= compare)
                {
                    k++;
                }
            }

            return k;

        }

     public static bool   RequiredCheck(string Value, string message)
        {
            if (Value == "")
            {
                ///messag
                return false;
            }
            else
            {
               return true;
            }
        }


        public static int GetCountMode(int[] arr, int compare)
        {
            var k = 0;
            var arrayLength = arr.Length - 1;
            for (int i = 0; i <= arrayLength; i = i + 1)
            {
                if (arr[i] % compare == 0)
                {
                    k++;
                }
            }

            return k;

        }
    }
}


//for (int i = 0; i < 100000; i++)
//{
//    h.Add(i, new Employee());
//    if (h.ContainsKey(i))
//    {
//        int empid = ((Employee)h[i]).Id;
//    }
//}
//Console.WriteLine("I am End Hash Table" + DateTime.Now.ToString());

//Dictionary<int, Employee> emp = new Dictionary<int, Employee>();
//Console.WriteLine("I am start Dictionary" + DateTime.Now.ToString());

//for (int i = 0; i < 100000; i++)
//{
//    emp.Add(i, new Employee());
//    if (emp.ContainsKey(i))
//    {
//        int empid = emp[i].Id;
//    }
//}
//Console.WriteLine("I am End Dictionary" + DateTime.Now.ToString());

//var LstEmployee = new List<Employee>();
////   m = "100";

////var strArr=  Utility.FileReadLines(@"D:\kmi\First\ConsoleAppFirst\HTMLPage1.html");
////  Employee e = new Employee { Name = "RajKapoor", Subject = "mvc.net" };

////  Person person = new Person { Name = "Keshav", Subject = "mvc.net" , Age=20 };
//// strArr = Utility.ReplaceValueFromObject(strArr, e);



////  Utility.FileWriteLines(@"home.html", strArr);
////  List<string> lst = new List<string>();

////  Utility.FileWriteLines(@"first.cs", lst.ToArray());