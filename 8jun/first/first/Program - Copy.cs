using first.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program2
    {

      private  int count = 0;

        public int Count { get{
                return count;


                    }
            set{

                  Console.WriteLine("I am in setter");
                  count = value*2;


            } }

        static void Main2(string[] args)
        {


            string[] names = { "Ashisha", "Abuzar", "Tushar", "Shubhma", "Rutuja" };

            var res = names.(X => X.Contains("T"));


         //var res=   names.GetEValues(X => X.Contains("b"));

         //   var resList = res.ToGetList();

            Console.Read();
            //   Program p = new Program();
            //   p.Count = 2;

            //   //string 
            //   //number 
            //   //boolean 
            //   //Array/collection 
            //   //Date 

            //   var name = "Krishmark";
            //   //name.IndexOfAny()

            //   //var nameLower = name.ToLower();
            //   //var arr = nameLower.ToCharArray();
            //   //var newArr = arr.Distinct().ToArray();
            //   //var str = Utilities.MyJoin(newArr,"");

            //   //var str2 = newArr.MyJoin("");
            //   //Console.WriteLine(str);

            //   int[] arrInt = { 1, 2, 3, 4, 7 };  //12347

            //   int[] arrCopy = new int[10];

            //   Array.Copy(arrInt,0, arrCopy,0, arrInt.Length);



            //   Console.Read();
            //   //int[] arrInt2 = new int[5];
            //   //int j = 0;
            //   //for (var i = 0; i < arrInt.Length; i = i + 1){
            //   //    if (arrInt[i] % 2 == 0)
            //   //    {
            //   //        arrInt2[j++] = arrInt[i];
            //   //    }
            //   //}

            //   //var result = Utilities.GetEvenValues(arrInt);
            //   //var result2 = Utilities.GetOddValues(arrInt);


            //   //result = Utilities.GetOpValues(arrInt,3, "Gte");
            //   //result = Utilities.GetOpValues(arrInt, 4, "Lte");

            //   var result = Utilities.GetValues<int>(arrInt, Program.IsEven
            //   );

            //   string[] names = { "Ashish", "Abuzar", "Tushar", "Shubhm", "Rutuja" };

            //   string[] resltnames = new string[names.Length];
            //   var j = 0;
            //   for(var i = 0; i < names.Length; i = i + 1)
            //   {
            //       if (names[i].StartsWith("R"))
            //       {
            //           resltnames[j++] = names[i];
            //       }
            //   }

            //var resultName=   (names.GetEValues<string>(x => x.StartsWith("R")) as List<string>).ToArray();

            //   List<string> lst = new List<string>(50);
            //  for(var i = 0; i < 20; i++)
            //   {
            //       lst.Add("a");
            //   }

            //   Console.Read();
            //   //result = Utilities.GetValues<int>(arrInt, (x)=> {

            //   //    return x % 2 == 1;

            //   //});
            //   //result = Utilities.GetValues<int>(arrInt, (int x) => {

            //   //    return x > 3;

            //   //});
            //   //result = Utilities.GetValues<int>(arrInt, x => x < 4);

            //   //result = Utilities.GetValues<int>(arrInt, x =>x > 5);
            //   // var str3= arrInt.MyJoin( "");


            //   /// provide me new string with distinct  char case insensitive 

        }


         public static bool IsEven(int val)
        {
            return val % 2 == 0;
        }

        

    }
}
