using first.utility;
using KMISMDBContext;
using KMISMEntities;
using KMISMModels;
using KMISMRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{

    /*Primitive Types
Reference & Value Types
Nullable Types
Constants & Fields
Properties, Methods, Events & Delegates.
Generics
Interfaces
Working with Chars, Strings & Text
Enums, Arrays.

     * 
     * 
     * 
     */
    class Program
    {




        static void SetValue(object obj, Dictionary<string,string> keyValuePairs)
        {
            Type type = obj.GetType();
            int i = 0;
            foreach (var item in keyValuePairs)
            {
                var propertyInfo = type.GetProperty(item.Key);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(obj, ConverData(item.Value, propertyInfo.PropertyType.ToString()));
                }

            }
        }

        static void SetValue(object obj, string[] strsplit, string[] columnNames)
        {            
            Type type = obj.GetType();
            var  propArray=  type.GetProperties(bindingAttr: System.Reflection.BindingFlags.Public);
            int i = 0;
            foreach(var key in columnNames)
            {
             var propertyInfo=   type.GetProperty(key);
                if (propertyInfo != null)
                {
                   propertyInfo.SetValue(obj, ConverData(strsplit[i++], propertyInfo.PropertyType.ToString()));
                }                
            }            
        }


       static dynamic GetDefaultValue(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

        static dynamic ConverData(string str, string type )
        {
            Type ty = Type.GetType(type);
            try
            {
                //Type t = Nullable.GetUnderlyingType(ty) ?? ty;

                return Convert.ChangeType(str, ty);
            }

            catch (Exception ex)
            {

                return GetDefaultValue(ty);
            }
        }

        static void MainOld34555(string[] args)
        {
            CustomRazor.generateNewFile(@"D:\kmi\8jun\first\Demo\Home_Index.html", "Home","Index");

        }


        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            List<int> list = new List<int>();
            Hashtable hashTable = new Hashtable();
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                
           
            for (int i = 0; i < 100000; i++)
            {
                var j = ("ABBBBBB" +i).GetHashCode();
                if (!list.Contains(j))
                {
                    list.Add(j);

                }
                
               
                hashTable.Add(i,j );
            }

            var data = hashTable[40000];


            Console.WriteLine(data);
            Console.ReadLine();

        }

        static void Main_Exam(string[] args)
        {

            var result = GetDistinctOrderByString("Abhay Velankar");
            Console.WriteLine(result);
            Console.ReadLine();

        }


        public static string GetDistinctOrderByString(string str)
        {
           var arr= str.ToLower().ToCharArray().Distinct().OrderBy(x => x).ToArray();

            return string.Join("", arr);
        }

            static void Main_______(string[] args)
        {

            using (new HTMLForm())
            {
                Console.WriteLine("<input />");
            }
                
            

            Console.Read();
        }
            static void MainOld12345x(string[] args)
        {
            StudentDBContext sdb = new StudentDBContext();


            //  var sub=  sdb.AddUpdateLoginUser(0, "Javascript");

            //var lstLoginUser = studentEntities.TblLoginUsers.OrderByDescending(x=>x.Name).Skip(2).Take(2).ToList();


            //sdb.StudentDbSet.Add(new Student
            //{
            //    FirstName = "Abuzar",
            //    LastName = "S",
            //    Age = 21,
            //    Doj = new DateTime(2021, 06, 11),
            //    LoginUserID = 1



            //});
            //sdb.SaveChanges();

            StudentRepository studentRepository = new StudentRepository();

            StudentSearchModel studentSearch = new StudentSearchModel();

            studentSearch.FirstName = "a";

            //studentSearch.AgeGte = "23";

            studentSearch.ColumnName = "FirstName";
            studentSearch.OrderBy = "desc";
            studentSearch.FirstName = "R";

            var lstStudent = studentRepository.GetStudents(studentSearch);

        
            Console.ReadLine();



        }
            static void MainEFOld(string[] args)
        {

           // var studentEntities =new studentsEntities();

            //studentEntities.TblLoginUsers.Add(new TblLoginUser
            //{

            //    Name = "Selenium"
            //});

            //studentEntities.TblLoginUsers.Add(new TblLoginUser
            //{

            //    Name = "Java"
            //});


            //studentEntities.TblLoginUsers.Add(new TblLoginUser
            //{

            //    Name = "Go"
            //});

          //var LoginUser=  studentEntities.TblLoginUsers.Where(x => x.Id == 5).FirstOrDefault();
          //  LoginUser.Name = LoginUser.Name + "1";

          //  var LoginUserDelete = studentEntities.TblLoginUsers.Where(x => x.Id == 4).FirstOrDefault();
          //  if (LoginUserDelete != null)
          //  {
          //      studentEntities.TblLoginUsers.Remove(LoginUserDelete);
          //  }
          //  studentEntities.SaveChanges();

            //var lstLoginUser = studentEntities.TblLoginUsers.OrderByDescending(x=>x.Name).Skip(2).Take(2).ToList();

            //foreach (var item in lstLoginUser)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Console.ReadLine();


        }

            static void Mainoldbinder(string[] args)
        {
         
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            keyValuePairs.Add("Id", "2");
            keyValuePairs.Add("FirstName", "QuickIt");
            keyValuePairs.Add("LastName", "DotNet");
            keyValuePairs.Add("Age", "33");

            Employee e = new Employee();
            
            SetValue(e, keyValuePairs);

            Type type = e.GetType();
            foreach (var key in type.GetProperties())
            {
                 

                Console.WriteLine(key.Name +"  " + key.GetValue(e));
            }

            Console.WriteLine(e);
            Console.Read();

        }
            static void Main7(string[] args)
        {

             
          var strArray=  System.IO.File.ReadAllLines(@"D:\kmi\8jun\first\first\data.txt");

            List<Person> empList = new List<Person>();

            List<string> errorList = new List<string>();


            string[] columnNames = { "Id", "Name", "Title", "Age" };
            for(var i=1; i < strArray.Length; i++)
            {
                Person emp = new Person();
              string[] strsplit=  strArray[i].Split('|');
                try
                {

                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
                    int j = 0;
                    foreach(var key in columnNames)
                    {
                        keyValuePairs.Add(key, strsplit[j++]);
                    }


                    SetValue(emp, keyValuePairs);
                    empList.Add(emp);
                }
                catch (FormatException fex)
                {
                    errorList.Add(fex.Message + " " + fex.StackTrace);
                }
                catch (IndexOutOfRangeException rex)
                {
                    errorList.Add(rex.Message + " " + rex.StackTrace);
                }
                catch (Exception ex)
                {
                    errorList.Add(ex.Message + " " + ex.StackTrace);
                }
                finally
                {
                    Console.WriteLine("I am in finally");
                }
               
            }
            Console.Read();


        }
            static void Main3(string[] args)
        {
             

            
            //string str = "ABhay";
            //bool isTrue = str == "abhay";
            //bool isTrue2 = string.Equals(null, null,StringComparison.OrdinalIgnoreCase);
            //str.Equals(null, StringComparison.OrdinalIgnoreCase);
            //char c =  (Char)('A' | 0x20);
            Console.Read();
            

            
            //int i = 0;
            ////bool z = false;
            //for(;; )
            //{
            //    if (!(i < 5))
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //    ++i;                
            //}


            //for (int k=0, m=0;k<6 && m< 3;k=k+1, m = m + 2)
            //{

            //}

            Console.WriteLine("------");
            //for (int i = 0; i < 5; ++i)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Read();

            //string[] names = { "Ashisha", "Abuzar", "Tushar", "Shubhma", "Rutuja" };
            //string str = "abhay";

            ////string 
            ////number 
            ////boolean 
            ////collection 
            ////date 

            //// integer/hole number 
            ////-->int , long , bigint , double , char , 
            //////floating point 

            ////byte b=0;
            ////short s=0;
            ////int i;
            ////long l;
            ////sbyte sb;
            ////ushort us;
            ////uint ui;
            ////ulong ul;


            ////float f;
            ////double d;


            ////Console.WriteLine("byte: " + byte.MaxValue + " " + byte.MinValue + " " + sizeof(byte));
            ////Console.WriteLine("short: " + short.MaxValue + " " + short.MinValue + " " + sizeof(short));
            ////Console.WriteLine("int: " + int.MaxValue + " " + int.MinValue + " " + sizeof(int));
            ////Console.WriteLine("long: " + long.MaxValue + " " + long.MinValue + " " + sizeof(long));
            ////Console.WriteLine("sbyte: " + sbyte.MaxValue + " " + sbyte.MinValue + " " + sizeof(sbyte));
            ////Console.WriteLine("ushort: " + ushort.MaxValue + " " + ushort.MinValue + " " + sizeof(ushort));
            ////Console.WriteLine("uint: " + uint.MaxValue + " " + uint.MinValue + " " + sizeof(uint));
            ////Console.WriteLine("ulong: " + ulong.MaxValue + " " + ulong.MinValue + " " + sizeof(ulong));


            ////Console.WriteLine(Math.Pow(2,16));


            ////for (int b1 = 0; b1 < 5; b1 = (byte)(b1 + 1))
            ////{

            ////}

            ////for (byte b1 = 0; b1 < 5; b1 = ((byte)(b1 + 1)))
            ////{

            ////}




            //////  2**(8*size -1) -1
            //////-2**(8*size)


            ////float f1 =12.2F;
            ////double d11 = 13.3D;
            ////decimal dc = 13.4M;


            //int i=12;
            //Calc2(ref i);
            //Console.WriteLine(i);

            //string str2 = "12";
            //int n;
            //Int32.TryParse(str2, out n);

            //Console.Read();
            ////string s = "abhay";
            ////s.ToArray()
            ////s.ToCharArray()

        }

        static void Calc2(ref int i)
        {

            //int z = i;
            i =i+ 1;


            //return i;
        }



        static void Calc(out int i)
        {

            //int z = i;
            i =  1;


            //return i;
        }

        

    }
}
