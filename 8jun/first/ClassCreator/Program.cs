using ClassCreator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace ClassCreator
{
    class Program
    {

        static int? i;
        static void Main(string[] args)
        {

            try
            {
                CallMe();
            }
            catch (DivideByZeroException dex)
            {

            }
            catch (CallMeException CEx)
            {
                Console.WriteLine(CEx.Message);
                Console.WriteLine(CEx.StackTrace);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.WriteLine(Ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("I am in finally");
            }


         
            //if (i!=null && i.HasValue && i.Value != 0)
            //{

            //  }





            Console.WriteLine("Value of Emmplyee Id");
            Console.ReadKey();

            //XslTransform xslTransform = new XslTransform();
            //xslTransform.Load(@"D:\kmi\8jun\first\ClassCreator\Service.xslt");
            //xslTransform.Transform(@"D:\kmi\8jun\first\ClassCreator\classData.xml", @"D:\kmi\8jun\first\output.cs");
      
        }



        public   static void CallMe()
        {
            throw new CallMeException();
        }
    }




   
}
