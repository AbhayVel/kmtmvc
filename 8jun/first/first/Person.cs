using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{


    public class HTMLForm : IDisposable
    {

        public HTMLForm()
        {
            Console.WriteLine("<Form >");
        }

       private bool isDispose = false;

        

        public void Dispose()
        {
            Dispose(isDispose);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                return;
            }
            Console.WriteLine("</form>");
            isDispose = true;
        }

    }



    public class Person : IDisposable
    {


      public Person()
        {

        }
        private bool isDispose=false;

        public int? Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public decimal Age { get; set; }

        public void Dispose()
        {
            Dispose(isDispose);
        }

        public void Dispose(bool isDispose)
        {
            if (isDispose)
            {
                return;
            }

            isDispose = true;
        }

    }



}
