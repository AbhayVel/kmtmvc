using CheckDatabaseFromEF;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCall
{
    public class Program
    {

        //public static void Main(string[] args)
        //{

        //    Dictionary<string, string> dictValues = new Dictionary<string, string>();
        //    dictValues.Add("Id", "1");
        //    dictValues.Add("FirstName", "Abhay");

        //    dictValues.Add("LastName", "Vel");



        // //   var user = new User();

        //    // class => Property +Methods
        //    // object => Property +Methods + state( memory location) 
        //    //class --> No
        //    //Object--> No
        //    //Polly--> No
        //    //------------------> Compile time 
        //    //--------------------->Runtime 
        //    //encapsulation
        //    //----------------->

        //    //Abstraction /hiding 
        //    //--------------->
        //    //inheritence 
        //    //------------>


        //    //user = ModelBinder(user, dictValues);
        //}


        //static T ModelBinder<T>(T obj, Dictionary<string, string> dict)
        //{

        //    ////
        //    ///
        //    ///

        //    return obj;
        //}


        public static void Main(string[] args)
        {
            Call();

            Nullable<int> i;

            int? j;

            Console.WriteLine("I am working");
            Console.Read();

        }

        public static void Call()
        {
            HttpClient httpClient = new HttpClient();

            var response = httpClient.GetAsync("https://localhost:44397/api/userapi/getdata");
            response.Wait();


            var output = response.Result;

            if (output.IsSuccessStatusCode)
            {

                var outPutTask = output.Content.ReadAsStringAsync();
                outPutTask.Wait();
                var data = outPutTask.Result;

                List<User> UserList = JsonConvert.DeserializeObject<List<User>>(data);


            }

            Console.WriteLine("I am working");
            Console.Read();
        }
    }
}

