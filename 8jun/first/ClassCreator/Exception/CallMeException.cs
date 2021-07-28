using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreator.Exceptions
{
  public  class CallMeException : Exception
    {

        public CallMeException() : base("I am called From Call Me")
        {

        }

    }
}
