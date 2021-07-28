using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.utility
{

    // public delegate ReturnType MyFunc<in InputType, out ReturnType>(InputType t);

  
    public  static class Utilities
    {
        public delegate Boolean MyFunc<in T, out Boolean>(T t);
        public static string MyJoin<T>(this T[] newArr, string c)
        {
            var str = "";

            for (int i = 0; i < newArr.Length; i = i + 1)
            {
                str = str + c + newArr[i].ToString();
            }

            return str;
        }


        public static int[] GetEvenValues(int[] arrInt)
        {
            int[] arrInt2 = new int[arrInt.Length];
            int j = 0;
            for (var i = 0; i < arrInt.Length; i = i + 1)
            {
                if (arrInt[i] % 2 == 0)
                {
                    arrInt2[j++] = arrInt[i];
                }
            }

            return arrInt2;
        }

        public static List<T> ToGetList<T>(this IEnumerable<T> arr)
        {
            List<T> lst = new List<T>();
            foreach(var key  in arr)
            {
                lst.Add(key);
            }


            return lst;
        }


        public static IEnumerable<T> GetEValues<T>(this IEnumerable<T> arr, MyFunc<T, bool> myFunc)
        {

          //  List<T> lst = new List<T>();
            foreach(var value in arr)
            {
                if (myFunc(value))
                {
                   yield return value;
                }
            }

           // return lst;
        }

        public static T[] GetValues<T>(this T[] arrInt, MyFunc<T,bool> myFunc)
        {
            T[] arrInt2 = new T[arrInt.Length];
            int j = 0;
            for (var i = 0; i < arrInt.Length; i = i + 1)
            {
                if (myFunc(arrInt[i]))
                {
                    arrInt2[j++] = arrInt[i];
                }
            }

            return arrInt2;
        }


        

        //public static int[] GetGreaterValues(int[] arrInt, int val)
        //{
        //    int[] arrInt2 = new int[arrInt.Length];
        //    int j = 0;
        //    for (var i = 0; i < arrInt.Length; i = i + 1)
        //    {
        //        if (arrInt[i] >= val)
        //        {
        //            arrInt2[j++] = arrInt[i];
        //        }
        //    }

        //    return arrInt2;
        //}


        //public static int[] GetOpValues(int[] arrInt, int val, string op)
        //{
        //    int[] arrInt2 = new int[arrInt.Length];
        //    int j = 0;
        //    for (var i = 0; i < arrInt.Length; i = i + 1)
        //    {
        //        if (op == "Gte")
        //        {
        //            if (arrInt[i] >= val)
        //            {
        //                arrInt2[j++] = arrInt[i];
        //            }
        //        } else if (op == "Lte")
        //        {
        //            if (arrInt[i] <= val)
        //            {
        //                arrInt2[j++] = arrInt[i];
        //            }
        //        }
        //        else if (op == "even")
        //        {
        //            if (arrInt[i] % 2==0)
        //            {
        //                arrInt2[j++] = arrInt[i];
        //            }
        //        }
        //        else if (op == "odd")
        //        {
        //            if (arrInt[i] %2==1)
        //            {
        //                arrInt2[j++] = arrInt[i];
        //            }
        //        }

        //    }

        //    return arrInt2;
        //}
        //public static int[] GetOddValues(int[] arrInt)
        //{
        //    int[] arrInt2 = new int[arrInt.Length];
        //    int j = 0;
        //    for (var i = 0; i < arrInt.Length; i = i + 1)
        //    {
        //        if (arrInt[i] % 2 == 1)
        //        {
        //            arrInt2[j++] = arrInt[i];
        //        }
        //    }

        //    return arrInt2;
        //}


        //public static string MyJoin(this int[] newArr, string c)
        //{
        //    var str = "";

        //    for (int i = 0; i < newArr.Length; i = i + 1)
        //    {
        //        str = str + c + newArr[i].ToString();
        //    }

        //    return str;
        //}


        //public static string MyJoin(this decimal[] newArr, string c)
        //{
        //    var str = "";

        //    for (int i = 0; i < newArr.Length; i = i + 1)
        //    {
        //        str = str + c + newArr[i].ToString();
        //    }

        //    return str;
        //}
    }
}
