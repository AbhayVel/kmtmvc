//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Web;

//namespace UtilityCore
//{
//    public class Binders
//    {



//        public static dynamic ConvertData(string value, Type type)
//        {
           
//            return Convert.ChangeType(value, type);
//        }


//        public static T MyModelBinder<T>(T obj, HttpRequest request, string prefix="")
//        {
//            Dictionary<string, string> d = new Dictionary<string, string>();

//            foreach (var item in request.Query)
//            {
//                if (d.ContainsKey(item.Key.ToLower()))
//                {
//                    d[item.Key.ToLower()] = item.Value;
//                }
//                else
//                {
//                    d.Add(item.Key.ToLower(), item.Value);
//                }
//            }

//            foreach (var item in request.Form)
//            {
//                if (d.ContainsKey(item.Key.ToLower()))
//                {
//                    d[item.Key.ToLower()] =item.Value;
//                } else
//                {
//                    d.Add(item.Key.ToLower(), item.Value);
//                }
               
//            }


//            if (string.IsNullOrEmpty(prefix))
//            {
//                return MyModelBinder(obj, d);
//            }
//           else
//            {
//                return MyModelBinder(obj, d, prefix);
//            }
//        }


//        public static T MyModelBinder<T>(T obj, Dictionary<string, string> d, string prefix)
//        {
//            var arr = new string[d.Keys.Count];
//            d.Keys.CopyTo(arr, 0);
//            var list = new List<string>();
//            Dictionary<string, string> dobj = new Dictionary<string, string>();
//            foreach (var it in arr)
//            {
//                if (it.StartsWith(prefix.ToLower()))
//                {
//                    list.Add(it);
//                }
//            }
//            var length = (prefix.ToLower() + ".").Length;
//            foreach (var ite in list)
//            {

//                dobj[ite.Substring(length).ToString()] = d[ite];

//            }
//            return MyModelBinder(obj, dobj);
//        }

//            public static T MyModelBinder<T>(T obj, Dictionary<string, string> d)
//        {
//            Type type = obj.GetType();


//            var arr = new string[d.Keys.Count];
//            d.Keys.CopyTo(arr,0);
//            var propInfoArray = type.GetProperties();

//            foreach (PropertyInfo item in propInfoArray)
//            {

//                if (item.PropertyType.IsClass  && !item.PropertyType.ToString().Equals( "System.String"))
//                {

//                   // item.PropertyType.CustomAttributes
//                    var str = arr.FirstOrDefault(x => x.StartsWith(item.Name.ToLower() + "."));
//                    if (str != null)
//                    {
//                        dynamic refObj = item.PropertyType.Assembly.CreateInstance(item.PropertyType.FullName);
//                        MyModelBinder(refObj, d, item.Name.ToLower());
//                        item.SetValue(obj, refObj);
//                    }
//                }
//                else
//                {
//                    if (d.ContainsKey(item.Name.ToLower()))
//                    {
//                        var value = ConvertData(d[item.Name.ToLower()], Type.GetType(item.PropertyType.ToString()));
//                        item.SetValue(obj, value);
//                    }
//                }
                
//            }
//            return obj;
//        }

//    }
//}
